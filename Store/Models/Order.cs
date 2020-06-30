using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<Cartlist> Carts { get; set; }
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter First line address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Enter City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter State")]
        public string State { get; set; }
         public int Zip { get; set; }
        [Required(ErrorMessage = "Enter Country")]
        public string Country { get; set; }
         public bool Giftwap { get; set; }
        [BindNever]
        public bool Shipped { get; set; }


    }
}
