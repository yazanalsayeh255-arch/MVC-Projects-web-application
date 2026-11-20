using CoffeeProject.Models.Cheese_Burger_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoffeeProject.Models
{
    public class AddressPages
    {
        
       [Key] public int Id { get; set; }
        [RequiredtextboxesValidations]public float price { get; set; }

        [Required] public int OrderId { get; set; }
        [ForeignKey("OrderId")] public OrderNames menuNames { get; set; }

        [Required] public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] public Category categoryOrder { get; set; }

        public bool Isarabic { get; set; }

        public int sizeId { get; set; }
        [ForeignKey("sizeId")] public Size sizeOrder { get; set; }

        //public int FormOrderId { get; set; }//sandwich or meal
        //[ForeignKey("FormOrderId")] public Size FormOrderId { get; set; }

    }
}