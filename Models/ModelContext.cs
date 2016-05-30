using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using TwitchChatForm.Models;

namespace TwitchChatForm.Models
{
    class ModelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
    }
}
