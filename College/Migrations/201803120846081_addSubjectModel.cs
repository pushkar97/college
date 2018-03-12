namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubjectModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        CourseId = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "CourseId", "dbo.Courses");
            DropIndex("dbo.Subjects", new[] { "CourseId" });
            DropTable("dbo.Subjects");
        }
    }
}
