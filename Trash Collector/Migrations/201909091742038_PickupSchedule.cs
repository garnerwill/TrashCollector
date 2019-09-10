namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickupSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ExtraPickUp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ExtraPickUp");
        }
    }
}
