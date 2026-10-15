using System;
using System.ComponentModel.DataAnnotations;

namespace Joo_Jeana_HW4.Models 
{   public enum ProductType { Clothing, Equipment, Accessories, Other }

    public class Product
    {
        public Int32 ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        public String Name { get; set; }

        public String? Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Product type is required.")]
        public ProductType ProductType { get; set; }
    }
}