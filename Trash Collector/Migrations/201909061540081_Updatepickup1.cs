namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepickup1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "UserName");
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.Customers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Customers", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
    }
}
