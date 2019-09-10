namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEditScreen1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "StartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "StartDate");
        }
    }
}
