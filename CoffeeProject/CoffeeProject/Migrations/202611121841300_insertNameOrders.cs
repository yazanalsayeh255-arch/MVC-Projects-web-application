namespace CoffeeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertNameOrders : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.[OrderNames] ON;");
            //breakfast
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(1,N'راب بيض وهاش براون')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(2,N'مافن حلوم+قهوة')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(3,N'مافن سجق وبيض+قهوة')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(4,N'راب عكاوي')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(5,N'قهوة أمريكية')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(6,N'هاش براون')");

            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (7,'Egg and Hash Browns wrap')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (8,'Halloumi Mffin+ Coffee')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (9,'Sausage Muffin Egg+ Coofee')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (10,'Akkawi Wrap')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (11,'American Coffee')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values (12,'Hash Browns')");



            //lunch
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(13,N'تشيز برجر')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(14,N' دبل تشيز برجر')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(15,N'تشيكن برجر')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(16,N'بيج تشيكن')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(17,N'سي بي تشيكن')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(18,N'تشيكن رويال')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(19,N'جراند تشيكن')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(20,N'تاستي')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(21,N'فاكتوري كينغ')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(22,N'دبل فاكتوري كينغ')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(23,N'بيج بيف')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(24,N'وجبة الأطفال')");

            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(25,'ChickenBurger')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(26,'Big Chicken')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(27,'CB chicken')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(28,'Chicken Royal')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(29,'Grand Chicken')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(30,'CheeseBurger')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(31,'Double Cheese Burger')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(32,'Tasty')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(33,'Factory King')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(34,'Double Factory King')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(35,'Big Beef')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(36,'Kid Meal')");

            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(37,N'شوكولاتة')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(38,N'فراولة')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(39,N'كراميل')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(40,'Chocolate')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(41,'Strawberry')");
            Sql("INSERT INTO dbo.[OrderNames] (id,CheeseBurgerNames) values(42,'Caramel')");

            Sql("SET IDENTITY_INSERT dbo.[OrderNames] OFF;");
        }

        public override void Down()
        {
        }
    }
}
