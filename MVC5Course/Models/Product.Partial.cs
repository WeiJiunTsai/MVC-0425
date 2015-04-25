namespace MVC5Course.Models
{
    using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product:IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Price < 2000)
            {
                yield return new ValidationResult("商品金額不得小於2000", new string[] { "Price" });
            }
            if(this.ProductName.Length < 5)
            {
                yield return new ValidationResult("產品名稱太短", new string[] { "ProductName" });
            }
        }
    }
    
    public partial class ProductMetaData
    {
        [Required]
        public int ProductId { get; set; }
        
        [StringLength(80, ErrorMessage="欄位長度不得大於 80 個字元")]
        public string ProductName { get; set; }
        [evenInt]
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> Stock { get; set; }
    
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
