namespace PremiereApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PremiereApp.Models.NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PremiereApp.Models.NewsContext";
        }

        protected override void Seed(PremiereApp.Models.NewsContext context)
        {
            context.Categories.AddOrUpdate(
                new Category() { CategoryId = 1, CategoryName = "Sports" },
                new Category() { CategoryId = 2, CategoryName = "Techno" },
                new Category() { CategoryId = 3, CategoryName = "Musique" }
              );

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
        }
    }
}
