namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDepartmentProfessorPostEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        EventId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentId = c.Byte(nullable: false),
                        ExperienceInYears = c.Byte(nullable: false),
                        PostId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professors", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Professors", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "EventId", "dbo.Events");
            DropIndex("dbo.Professors", new[] { "PostId" });
            DropIndex("dbo.Professors", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "EventId" });
            DropTable("dbo.Professors");
            DropTable("dbo.Posts");
            DropTable("dbo.Events");
            DropTable("dbo.Departments");
        }
    }
}
