namespace CoffeeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class global : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddressPages", "cakes_Amman");
            DropColumn("dbo.AddressPages", "sweets");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddressPages", "sweets", c => c.String());
            AddColumn("dbo.AddressPages", "cakes_Amman", c => c.String());
        }
    }
}
