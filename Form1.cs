using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using TwitchChatForm.Models;
using System.Diagnostics;

namespace TwitchChatForm
{
    public partial class Form1 : Form
    {

        User user = new User();
        ModelContext db = new ModelContext();

        Queue<string> sendMessageQueue;

        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;
        string channel;
        string userName; //Don't confuse this with member UserName of class User
        string password;
        string chatMessagePrefix;
        string chatMessageKeyword;
        string chatJoinKeyword;
        string chatPartKeyword;
        DateTime lastMessage;
        List<User> ActiveUsers;
        bool JoinPart;
        bool verboseChat;
       

        public Form1()
        {
            //User user = new User
            //{
            //    UserName = "Test",
            //    Minutes = 0,
            //};

            //ListBox listBox1 = new ListBox();
            

            //db.Users.Add(user);
            ActiveUsers = new List<User>();
            textBox2 = new TextBox();
            textBox2.Text = "Total users in db: " + db.Users.Count().ToString();
            QueueCount = new TextBox();
            verboseChat = true;
            //ActiveUsers.Add(user);
            //textBox1 = new TextBox();

            db.SaveChanges();

            //User user2 = db.Users.First();

            sendMessageQueue = new Queue<string>();
            QueueCount.Text = sendMessageQueue.Count.ToString();
            this.userName = "expansionteam".ToLower();

            this.password = File.ReadAllText(@"oauth.txt", Encoding.UTF8);

            this.channel = "PandaXGaming".ToLower();
            chatMessageKeyword = "PRIVMSG";
            chatJoinKeyword = "JOIN";
            chatPartKeyword = "PART";
            chatMessagePrefix = $":{userName}!{userName}@{userName}.tmi.twitch.tv {chatMessageKeyword} #{channel} :";
            InitializeComponent();
            Reconnect();
        }

        private void Reconnect()
        {
            AppMessageBox.Text = "Starting the bot.";
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());
            writer.AutoFlush = true;


            var loginString = "PASS " + password + Environment.NewLine
                + "NICK " + userName + Environment.NewLine
                + "USER " + userName + " 8 * :" + userName;

            //writer.WriteLine("PASS " + password + Environment.NewLine
            //    + "NICK " + userName + Environment.NewLine
            //    + "USER " + userName + " 8 * :" + userName);

            writer.WriteLine(loginString);
            Chat.AppendText(loginString + "\r\n");

            writer.WriteLine("CAP REQ :twitch.tv/membership");
            Chat.AppendText("CAP REQ :twitch.tv/membership" + "\r\n");

            writer.WriteLine("JOIN #" + channel);
            Chat.AppendText("JOIN #" + channel + "\r\n");
            //writer.Flush();
            lastMessage = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void timer1_Tick(object sender, EventArgs e)
        //void Update(object sender, EventArgs e)
        {
            //Main loop here.  If not connected, reconnect
            if(!tcpClient.Connected)
            {
                Reconnect();
            }

            //Send out messages in the queue
            TrySendingMessages();

            //Receive messages
            TryReceiveMessages();

        }

        void TrySendingMessages()
        {
            if (DateTime.Now - lastMessage > TimeSpan.FromSeconds(8))
            {
                if (sendMessageQueue.Count > 0)
                {
                    var message = sendMessageQueue.Dequeue();
                    writer.WriteLine($"{chatMessagePrefix}{message}");

                    if (verboseChat)
                    {
                        Chat.AppendText($"\r\n{message}");
                    }
                    //writer.Flush();
                    lastMessage = DateTime.Now;
                    QueueCount.Text = sendMessageQueue.Count.ToString();
                }
            }
        }

        //Message parser
        private void TryReceiveMessages()
        {

            if (tcpClient.Available > 0 || reader.Peek() >= 0)
            {
                //Store message to variable
                var message = reader.ReadLine();
                JoinPart = false;

                //Write to program window
                if(verboseChat)
                    Chat.AppendText($"\r\n" + message);

                //Check for ping, respond with pong
                if(message.StartsWith("PING"))
                {
                    writer.WriteLine("PONG" + message.Substring(5) + "\r\n");
                }

                //Look for a colon beyond the first character
                var iColon = message.IndexOf(":", 1);

                //This is a user list message when you first join a channel
                if(message.StartsWith(":" + userName + ".tmi.twitch.tv 353 " + userName
                                      + " = #" + channel))
                {
                    var iEquals = message.IndexOf("=");
                    var x = message.Length;

                    //Plus 5 at the end for two spaces, a #, a :, and the = itself
                    var userListString = message.Substring(iEquals + channel.Length + 5);
                    String[] userList = userListString.Split(' ');

                    foreach(var item in userList)
                    {
                        UserJoin(item);
                    }
                }

                //If a colon is found, we presume it's a chat message from a user
                //(as opposed to a system message)
                if (iColon > 0)
                {
                    var command = message.Substring(1, iColon);

                    if (command.Contains(chatMessageKeyword))
                    {
                        var iBang = command.IndexOf("!");

                        if (iBang > 0)
                        {
                            var speaker = command.Substring(0, iBang);
                            var chatMessage = message.Substring(iColon + 1);

                            ReceiveMessage(speaker, chatMessage);
                        }
                    }
                } //end iColon

                //We could probably make this an elseif off of the if iColon > 0 above.
                //We're checking for the JOIN keyword
                if (message.Contains(chatJoinKeyword + " #" + channel))
                {
                    var iBang = message.IndexOf("!");
                    var speaker = message.Substring(1, iBang - 1);

                    if(!db.Users.Any(n => n.UserName == speaker))
                    {
                        NewUser(speaker);
                    }

                    User user = db.Users.FirstOrDefault(n => n.UserName == speaker);
                    

                    if (!ActiveUsers.Contains(user))
                    {
                        listBox1.Items.Add(user.UserName);
                        listBox1.Sorted = true;
                        ActiveUsers.Add(user);
                        textBox1.Text = "Number of users: " + listBox1.Items.Count.ToString();
                    }

                    JoinPart = true;
                }

                //Checking for the PART keyword
                if (message.Contains(chatPartKeyword + "#" + channel))
                {
                    var iBang = message.IndexOf("!");
                    var speaker = message.Substring(1, iBang - 1);

                    //Check to make sure they're a user before removal.
                    //This probably needs optimizing, as any database call
                    //add processing time.
                    if (db.Users.Any(n => n.UserName == speaker))
                    {
                        User user = db.Users.First(n => n.UserName == speaker);
                    }

                    if (ActiveUsers.Contains(user))
                    {
                        //With this logic, I believe that a use who leaves will not
                        //get credit for the last minute they are present.
                        listBox1.Items.Remove(user.UserName);
                        listBox1.Sorted = true;
                        ActiveUsers.Remove(user);
                        textBox1.Text = "Number of users: " + listBox1.Items.Count.ToString();
                    }

                    JoinPart = true;
                }

                if(JoinPart)
                {
                    TimeUpdate();
                }
            }
        }


        void ReceiveMessage(string speaker, string chatMessage)
        {
            Chat.AppendText($"\r\n{speaker}: {chatMessage} \r\n");
           

            if (chatMessage.StartsWith("!hi"))
            {
                SendMessage($"Hello, {speaker}");
            }

            if (chatMessage.StartsWith("!mystats"))
            {
                User user = db.Users.First(n => n.UserName == speaker);
                double timeUntilLevelUp = (user.NextLevel - user.LevelProgress).TotalMinutes;
                double timeRounded = Math.Round(timeUntilLevelUp);
                
                var messageString = speaker + "'s stats:  Viewer level is " + user.ViewerLevel.ToString()
                    + ".  You will level up after " + timeRounded.ToString() + " more minutes of viewing.";

                SendMessage(messageString);
            }

            if (chatMessage.StartsWith("!friedchicken"))
            {


                var messageString = "*Hands " + speaker + " a bucket of extra crispy thighs.*";

                SendMessage(messageString);
            }

            if(chatMessage.StartsWith("!nextlevel"))
            {
                AppMessageBox.Text = "Finding the user closest to leveling.";
                List<User> allUsers = db.Users.ToList();
                var name = "";
                double howClose = 999;

                foreach(var item in allUsers)
                {
                    if((item.NextLevel - item.LevelProgress).TotalMinutes < howClose)
                    {
                        name = item.UserName;
                        howClose = (item.NextLevel - item.LevelProgress).TotalMinutes;
                        howClose = Math.Round(howClose);
                    }
                }

                var messageString = "The user closest to leveling up is " + name + ", and they are "
                    + howClose.ToString() + " minute(s) from leveling.";

                SendMessage(messageString);

                AppMessageBox.Text = "";
            }




        }

        void SendMessage(string message)
        {
            sendMessageQueue.Enqueue(message);
            QueueCount.Text = sendMessageQueue.Count.ToString();
        }

        //New User
        void NewUser(string speaker)
        {
            User newUser = new User
            {
                UserName = speaker,
                LevelProgress = TimeSpan.FromMinutes(1),
                Xp = 0,
                ViewerLevel = 0,
                NextLevel = TimeSpan.FromMinutes(30),
                Latest = DateTime.Now,

            };

            db.Users.Add(newUser);
            textBox2.Text = "Total users in db: " + db.Users.Count().ToString();
            db.SaveChanges();
        }

        void UserJoin(string speaker)
        {
            if (!db.Users.Any(n => n.UserName == speaker))
            {
                NewUser(speaker);
            }

            User user = db.Users.FirstOrDefault(n => n.UserName == speaker);

            if (!ActiveUsers.Contains(user))
            {
                listBox1.Items.Add(user.UserName);
                listBox1.Sorted = true;
                user.Latest = DateTime.Now;
                ActiveUsers.Add(user);
                textBox1.Text = "Current registered viewers: " + listBox1.Items.Count.ToString();
            }
        }

        void TimeUpdate()
        {
            AppMessageBox.Text = "Updating user time, XP, and levels.";
            DateTime currentTime = DateTime.Now;

            foreach(var item in ActiveUsers)
            {
                item.LevelProgress += (currentTime - item.Latest);
                item.Latest = currentTime;

                if(item.LevelProgress >= item.NextLevel)
                {
                    item.ViewerLevel += 1;
                    item.NextLevel += TimeSpan.FromMinutes(10);
                    item.LevelProgress = TimeSpan.FromMinutes(0);
                    sendMessageQueue.Enqueue(item.UserName + " has reached viewer level "
                        + item.ViewerLevel.ToString() + "!");
                }
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            AppMessageBox.Text = "";
            User Expandingman = db.Users.First(n => n.UserName == "Expandingman");
            ExpandingmanName.Text = Expandingman.UserName;
            ExpandingmanLatest.Text = Expandingman.Latest.ToString();
            ExpandingmanLevel.Text = Expandingman.ViewerLevel.ToString();
            ExpandingmanCurrent.Text = Expandingman.LevelProgress.ToString();
            ExpandingmanNextLevel.Text = Expandingman.NextLevel.ToString();

            if (listBox1.SelectedItem == null)
            {
                listBox1.SelectedIndex = 0;
            }

            StatsUpdate(listBox1.SelectedItem.ToString());
        }

        void StatsUpdate(string userName)
        {
            User user = db.Users.First(n => n.UserName == userName);
            UserNameBox.Text = user.UserName;
            UserCurrentBox.Text = user.LevelProgress.ToString();
            UserLatestBox.Text = user.Latest.ToString();
            UserLevelBox.Text = user.ViewerLevel.ToString();
            UserNextLevelBox.Text = user.NextLevel.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = listBox1.SelectedItem.ToString();
            StatsUpdate(user);
  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Some finishing code here.  Run timeUpdate, I suppose
            TimeUpdate();
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (verboseChat == false)
            {
                verboseChat = true;
            } else
            {
                verboseChat = false;
            }
        }
    }
}
