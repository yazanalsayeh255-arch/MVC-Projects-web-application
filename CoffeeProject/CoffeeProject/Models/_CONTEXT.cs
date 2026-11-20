using CoffeeProject.Models;
using CoffeeProject.Models.Cheese_Burger_Menu;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TESTING.Models
{
    public class _CONTEXT : DbContext
    {
        public _CONTEXT() : base("Resturant")
        {
        }

        public _CONTEXT(string Resturant) : base(Resturant)
        {
        }
        public DbSet<AddressPages> NameAddressPages { get; set; }
        public DbSet<Category> CategoryList { get; set; }
        public DbSet<OrderNames> MenuList { get; set; }
        public DbSet<Size> SizeList { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }
    }
}
