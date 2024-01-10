using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFormMvcApp.Models
{
    public class Product
    {   [Display(Name="Urun Id")]
        public int ProductId { get; set; }
        [Display(Name="Urun Adi")]
        public string Name { get; set; }
        [Display(Name="Urun Fiyati")]
        public double Price {get; set;}
        [Display(Name="Urun Fotografi")]
        public string Image { get; set; }
        public bool IsActive {get; set;}
        public int CategoryId {get; set;}
    }
}