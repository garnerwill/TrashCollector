namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepickup2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DaysofWeek", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DaysofWeek");
        }
    }
}
