using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeProject.Models.Cheese_Burger_Menu
{
    public class RequiredtextboxesValidations : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var addressPage = (AddressPages)validationContext.ObjectInstance;

          
            if (addressPage.price <= 0)//the properity must be null
            {
                return new ValidationResult("Price must be greater than 0.");
            }
           
            return ValidationResult.Success;

        }
    }
}