using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeProject.Models.Cheese_Burger_Menu
{
    public class Category
    {
        [Key]public int id { get; set; }
        public string CategoryName { get; set; } 
    }
}