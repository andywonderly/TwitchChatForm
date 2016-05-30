using System.Data.Entity;

namespace TwitchChatForm.Models
{
    internal class IdentityDBContext<T>
    {
        class DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<CharacterClass> CharacterClasses { get; set; }
        }
    }
}