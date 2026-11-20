namespace CoffeeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insert4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.[Sizes] ON;");

            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(1,N'صغير')");
            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(2,N'وسط')");
            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(3,N'كبير')");
            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(4,'Small')");
            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(5,N'Meduim')");
            Sql("Insert into dbo.[Sizes] (Id,Namesize) values(6,N'Large')");
            Sql("SET IDENTITY_INSERT dbo.[Sizes] OFF;");

        }

        public override void Down()
        {
        }
    }
}
