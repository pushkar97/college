namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIdentityAttributeToAllExceptDept : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "EventId", "dbo.Events");
            DropForeignKey("dbo.Professors", "PostId", "dbo.Posts");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Events");
            DropPrimaryKey("dbo.Posts");
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.Events", "Id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.Posts", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Events", "Id");
            AddPrimaryKey("dbo.Posts", "Id");
            AddForeignKey("dbo.Departments", "EventId", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Professors", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professors", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Departments", "EventId", "dbo.Events");
            DropPrimaryKey("dbo.Posts");
            DropPrimaryKey("dbo.Events");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Posts", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Events", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Posts", "Id");
            AddPrimaryKey("dbo.Events", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            AddForeignKey("dbo.Professors", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Departments", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
    }
}
