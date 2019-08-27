namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tasks", "Done");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Done", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tasks", "Status");
        }
    }
}
