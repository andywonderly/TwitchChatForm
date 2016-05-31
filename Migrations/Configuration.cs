namespace TwitchChatForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TwitchChatForm.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TwitchChatForm.Models.ModelContext>
    {
        ModelContext db = new ModelContext();

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TwitchChatForm.Models.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (db.Users.Count() < 1)
            {
                db.Users.Add(new User
                {
                    UserName = "Expandingman",
                    LevelProgress = TimeSpan.FromMinutes(29),
                    NextLevel = TimeSpan.FromMinutes(30),
                    Latest = DateTime.Now,
                    Xp = 1,
                    ViewerLevel = 1,
                });

                db.SaveChanges();
            }

            if (db.CharacterClasses.Count() < 1)
            {
                db.CharacterClasses.Add(new CharacterClass
                {
                    ClassName = "Mage",

                });

                db.SaveChanges();
            }

        }
    }
}
