using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeProject.Models.Cheese_Burger_Menu
{
    public class RandomCheeseBurger
    {
        
       public AddressPages ADpages { get; set; }
        public List<AddressPages> ADpageslist { get; set; }//for list of the view in foreachlist
        public IEnumerable<Category>categorylist { get; set; }
        public IEnumerable<OrderNames>orderlist { get; set; }
        public IEnumerable<Size>sizelist { get; set; }


    }
}