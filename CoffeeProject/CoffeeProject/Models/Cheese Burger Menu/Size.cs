using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeProject.Models.Cheese_Burger_Menu
{
    public class Size
    {
      [Key]public int Id { get; set; }
        public string Namesize { get; set; }
    }
}