namespace TwitchChatForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Chat1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Chat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AppMessageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpandingmanName = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.ExpandingmanLevel = new System.Windows.Forms.TextBox();
            this.UserLevelBox = new System.Windows.Forms.TextBox();
            this.ExpandingmanCurrent = new System.Windows.Forms.TextBox();
            this.UserCurrentBox = new System.Windows.Forms.TextBox();
            this.ExpandingmanLatest = new System.Windows.Forms.TextBox();
            this.UserLatestBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpandingmanNextLevel = new System.Windows.Forms.TextBox();
            this.UserNextLevelBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueueCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chat1
            // 
            this.Chat1.AutoSize = true;
            this.Chat1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Chat1.Location = new System.Drawing.Point(12, 44);
            this.Chat1.Name = "Chat1";
            this.Chat1.Size = new System.Drawing.Size(41, 17);
            this.Chat1.TabIndex = 0;
            this.Chat1.Text = "Chat:";
            this.Chat1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Chat
            // 
            this.Chat.Location = new System.Drawing.Point(12, 64);
            this.Chat.Multiline = true;
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat.Size = new System.Drawing.Size(608, 527);
            this.Chat.TabIndex = 1;
            this.Chat.TextChanged += new System.EventHandler(this.Chat_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(626, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(258, 468);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 569);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(258, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AppMessageBox
            // 
            this.AppMessageBox.Location = new System.Drawing.Point(12, 618);
            this.AppMessageBox.Name = "AppMessageBox";
            this.AppMessageBox.Size = new System.Drawing.Size(457, 22);
            this.AppMessageBox.TabIndex = 5;
            this.AppMessageBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "System message:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ExpandingmanName
            // 
            this.ExpandingmanName.Location = new System.Drawing.Point(902, 423);
            this.ExpandingmanName.Name = "ExpandingmanName";
            this.ExpandingmanName.ReadOnly = true;
            this.ExpandingmanName.Size = new System.Drawing.Size(152, 22);
            this.ExpandingmanName.TabIndex = 8;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(971, 69);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.ReadOnly = true;
            this.UserNameBox.Size = new System.Drawing.Size(301, 22);
            this.UserNameBox.TabIndex = 9;
            // 
            // ExpandingmanLevel
            // 
            this.ExpandingmanLevel.Location = new System.Drawing.Point(902, 451);
            this.ExpandingmanLevel.Name = "ExpandingmanLevel";
            this.ExpandingmanLevel.ReadOnly = true;
            this.ExpandingmanLevel.Size = new System.Drawing.Size(152, 22);
            this.ExpandingmanLevel.TabIndex = 10;
            // 
            // UserLevelBox
            // 
            this.UserLevelBox.Location = new System.Drawing.Point(971, 97);
            this.UserLevelBox.Name = "UserLevelBox";
            this.UserLevelBox.ReadOnly = true;
            this.UserLevelBox.Size = new System.Drawing.Size(301, 22);
            this.UserLevelBox.TabIndex = 11;
            // 
            // ExpandingmanCurrent
            // 
            this.ExpandingmanCurrent.Location = new System.Drawing.Point(902, 480);
            this.ExpandingmanCurrent.Name = "ExpandingmanCurrent";
            this.ExpandingmanCurrent.ReadOnly = true;
            this.ExpandingmanCurrent.Size = new System.Drawing.Size(152, 22);
            this.ExpandingmanCurrent.TabIndex = 12;
            // 
            // UserCurrentBox
            // 
            this.UserCurrentBox.Location = new System.Drawing.Point(972, 125);
            this.UserCurrentBox.Name = "UserCurrentBox";
            this.UserCurrentBox.ReadOnly = true;
            this.UserCurrentBox.Size = new System.Drawing.Size(301, 22);
            this.UserCurrentBox.TabIndex = 13;
            // 
            // ExpandingmanLatest
            // 
            this.ExpandingmanLatest.Location = new System.Drawing.Point(902, 509);
            this.ExpandingmanLatest.Name = "ExpandingmanLatest";
            this.ExpandingmanLatest.ReadOnly = true;
            this.ExpandingmanLatest.Size = new System.Drawing.Size(152, 22);
            this.ExpandingmanLatest.TabIndex = 14;
            // 
            // UserLatestBox
            // 
            this.UserLatestBox.Location = new System.Drawing.Point(972, 154);
            this.UserLatestBox.Name = "UserLatestBox";
            this.UserLatestBox.ReadOnly = true;
            this.UserLatestBox.Size = new System.Drawing.Size(301, 22);
            this.UserLatestBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(903, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "CurSess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Latest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(903, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "NextLev";
            // 
            // ExpandingmanNextLevel
            // 
            this.ExpandingmanNextLevel.Location = new System.Drawing.Point(902, 541);
            this.ExpandingmanNextLevel.Name = "ExpandingmanNextLevel";
            this.ExpandingmanNextLevel.ReadOnly = true;
            this.ExpandingmanNextLevel.Size = new System.Drawing.Size(152, 22);
            this.ExpandingmanNextLevel.TabIndex = 21;
            // 
            // UserNextLevelBox
            // 
            this.UserNextLevelBox.Location = new System.Drawing.Point(972, 186);
            this.UserNextLevelBox.Name = "UserNextLevelBox";
            this.UserNextLevelBox.ReadOnly = true;
            this.UserNextLevelBox.Size = new System.Drawing.Size(301, 22);
            this.UserNextLevelBox.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // QueueCount
            // 
            this.QueueCount.Location = new System.Drawing.Point(1119, 571);
            this.QueueCount.Name = "QueueCount";
            this.QueueCount.ReadOnly = true;
            this.QueueCount.Size = new System.Drawing.Size(100, 22);
            this.QueueCount.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(899, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Outgoing message queue count:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 624);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(971, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Selected user\'s stats";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(902, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "My stats";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(78, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 21);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Verbose chat";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 652);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QueueCount);
            this.Controls.Add(this.UserNextLevelBox);
            this.Controls.Add(this.ExpandingmanNextLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserLatestBox);
            this.Controls.Add(this.ExpandingmanLatest);
            this.Controls.Add(this.UserCurrentBox);
            this.Controls.Add(this.ExpandingmanCurrent);
            this.Controls.Add(this.UserLevelBox);
            this.Controls.Add(this.ExpandingmanLevel);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.ExpandingmanName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppMessageBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.Chat1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Expandingman\'s Twitch bot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chat1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Chat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox AppMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpandingmanName;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox ExpandingmanLevel;
        private System.Windows.Forms.TextBox UserLevelBox;
        private System.Windows.Forms.TextBox ExpandingmanCurrent;
        private System.Windows.Forms.TextBox UserCurrentBox;
        private System.Windows.Forms.TextBox ExpandingmanLatest;
        private System.Windows.Forms.TextBox UserLatestBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExpandingmanNextLevel;
        private System.Windows.Forms.TextBox UserNextLevelBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox QueueCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

