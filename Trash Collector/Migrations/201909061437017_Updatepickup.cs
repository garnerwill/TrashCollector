namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepickup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Pickup", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Pickup");
        }
    }
}
