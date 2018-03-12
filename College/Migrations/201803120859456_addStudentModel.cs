namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Age = c.Byte(nullable: false),
                        Address = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CourseId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropTable("dbo.Students");
        }
    }
}
