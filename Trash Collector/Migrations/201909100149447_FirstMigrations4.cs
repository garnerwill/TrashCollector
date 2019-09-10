namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrations4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ConfirmPickup", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "WeeklyCharges", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "WeeklyCharges");
            DropColumn("dbo.Employees", "ConfirmPickup");
        }
    }
}
