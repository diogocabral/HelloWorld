namespace HelloWorld.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using HelloWorld.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HelloWorld.DAL.HelloWorldContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HelloWorld.DAL.HelloWorldContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var users = new List<User>
            {
                new User{Name="Diogo Cabral"},
                new User{Name="Reinaldo Cabral"},
                new User{Name="Rodrigo Paes"},
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
