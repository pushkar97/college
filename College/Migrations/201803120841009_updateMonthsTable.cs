namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMonthsTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Months");
            AlterColumn("dbo.Months", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Months", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Months");
            AlterColumn("dbo.Months", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Months", "Id");
        }
    }
}
