namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Done : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Done");
        }
    }
}
