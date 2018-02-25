namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatetimeToCustomer2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "dateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "dateTime", c => c.DateTime(nullable: false));
        }
    }
}
