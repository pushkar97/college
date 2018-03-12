namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addExamModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 255),
                        CourseId = c.Byte(nullable: false),
                        DateOfExam = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "CourseId", "dbo.Courses");
            DropIndex("dbo.Exams", new[] { "CourseId" });
            DropTable("dbo.Exams");
        }
    }
}
