namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoList.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.Models.TaskDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ToDoList.Models.TaskDbContext";
        }

        protected override void Seed(ToDoList.Models.TaskDbContext context)
        {
            context.Tasks.AddOrUpdate( i => i.Title,
                new Task
                {
                    Status = true,
                    Title = "asasas",
                    Description = "lkasmnlkjnaskja"
                }
               
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
