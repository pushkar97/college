namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttendanceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonthId = c.Byte(nullable: false),
                        StudentId = c.Int(nullable: false),
                        AttendanceInPercent = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Months", t => t.MonthId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.MonthId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Attendances", "MonthId", "dbo.Months");
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropIndex("dbo.Attendances", new[] { "MonthId" });
            DropTable("dbo.Attendances");
        }
    }
}
