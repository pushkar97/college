namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventIdMadeNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "EventId", "dbo.Events");
            DropIndex("dbo.Departments", new[] { "EventId" });
            AlterColumn("dbo.Departments", "EventId", c => c.Byte());
            CreateIndex("dbo.Departments", "EventId");
            AddForeignKey("dbo.Departments", "EventId", "dbo.Events", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "EventId", "dbo.Events");
            DropIndex("dbo.Departments", new[] { "EventId" });
            AlterColumn("dbo.Departments", "EventId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Departments", "EventId");
            AddForeignKey("dbo.Departments", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
    }
}
