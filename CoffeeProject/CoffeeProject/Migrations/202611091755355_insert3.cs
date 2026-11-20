namespace CoffeeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insert3 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.[Categories] SET CategoryName = 'Breakfast' WHERE Id = 1;");
            Sql("UPDATE dbo.[Categories] SET CategoryName = 'Lunch' WHERE Id = 2;");
            Sql("UPDATE dbo.[Categories] SET CategoryName = 'Dinner' WHERE Id = 3;");
        }
        
        public override void Down()
        {
        }
    }
}
