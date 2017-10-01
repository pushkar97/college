namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Posts", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Professors", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Seminars", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Seminars", "Name", c => c.String());
            AlterColumn("dbo.Professors", "Name", c => c.String());
            AlterColumn("dbo.Posts", "Name", c => c.String());
            AlterColumn("dbo.Events", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
