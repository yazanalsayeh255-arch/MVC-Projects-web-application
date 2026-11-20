namespace CoffeeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdfgrth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressPages", "price", c => c.Single(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddressPages", "price", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
