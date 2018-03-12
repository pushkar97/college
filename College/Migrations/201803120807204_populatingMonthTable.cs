namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingMonthTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Months (Name) VALUES ('January')");
            Sql("INSERT INTO Months (Name) VALUES ('February')");
            Sql("INSERT INTO Months (Name) VALUES ('March')");
            Sql("INSERT INTO Months (Name) VALUES ('April')");
            Sql("INSERT INTO Months (Name) VALUES ('May')");
            Sql("INSERT INTO Months (Name) VALUES ('June')");
            Sql("INSERT INTO Months (Name) VALUES ('July')");
            Sql("INSERT INTO Months (Name) VALUES ('August')");
            Sql("INSERT INTO Months (Name) VALUES ('September')");
            Sql("INSERT INTO Months (Name) VALUES ('october')");
            Sql("INSERT INTO Months (Name) VALUES ('November')");
            Sql("INSERT INTO Months (Name) VALUES ('December')");
        }
        
        public override void Down()
        {
        }
    }
}
