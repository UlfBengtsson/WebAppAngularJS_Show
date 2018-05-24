namespace WebAppAngularJS_Show.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppAngularJS_Show.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppAngularJS_Show.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAppAngularJS_Show.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.FirstName,
              new Person { FirstName = "Andrew", LastName = "Peters" },
              new Person { FirstName = "Brice", LastName = "Lambson" },
              new Person { FirstName = "Rowan", LastName = "Miller" }
            );

            context.Cars.AddOrUpdate(
              c => c.Name,
              new Car { Name = "9-3", Brand = "Saab" },
              new Car { Name = "740", Brand = "Volvo" },
              new Car { Name = "350i", Brand = "BMW" }
            );

            context.SaveChanges();
        }
    }
}
