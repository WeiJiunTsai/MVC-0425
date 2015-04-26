using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class SimpleViewModel: IValidatableObject
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        [Compare("PassWord")]
        public string ComfirmPassWord { get; set; }
        [Required]
        public int age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}