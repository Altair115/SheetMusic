namespace SheetMusic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SheetMusic.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SheetMusic.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SheetMusic.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }

        /// <summary>
        /// Adds a test user
        /// </summary>
        /// <param name="context">user name</param>
        void AddUsers(SheetMusic.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "Boris@slav.com" };
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            um.Create(user, "#BBQ123");
        }
    }
}
