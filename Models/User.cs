using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwitchChatForm.Models
{
    class User
    {
        
        public int Id { get; set; }
        public int CharacterClassId { get; set; }
        public string UserName { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLevel { get; set; }
        public TimeSpan LevelProgress { get; set; }
        public int ViewerLevel { get; set; }
        public int Xp { get; set; }
        public TimeSpan NextLevel { get; set; }
        public bool Subscriber { get; set; }
        public DateTime Latest { get; set; }

        //public virtual CharacterClass Character {get; set;}



    }

}
