namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatetimeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "dateTime");
        }
    }
}
