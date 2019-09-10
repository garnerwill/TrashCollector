namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingusercreatescreen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "TrashDay", c => c.String());
            DropColumn("dbo.Customers", "DaysofWeek");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DaysofWeek", c => c.String());
            DropColumn("dbo.Customers", "TrashDay");
        }
    }
}
