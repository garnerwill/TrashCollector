namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrations3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "pickUpdate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "pickUpdate");
        }
    }
}
