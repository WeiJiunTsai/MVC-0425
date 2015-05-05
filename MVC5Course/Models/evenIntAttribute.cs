using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class evenIntAttribute:DataTypeAttribute
    {
        public evenIntAttribute() : base("evenInt")
        {
            ErrorMessage = "數字需為偶數!";
        }
        public override bool IsValid(object value)
        {
            
            if (value == null ) { return false; }

            Decimal num;
            if (Decimal.TryParse(value.ToString(), out num))
            {
                if(num != 0 && num % 2 == 0)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
    }
}