using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Cart
    {
        public List<Cartlist> Carts { get; set; } = new List<Cartlist>();
        public virtual void Product(Details details,int quantity)
        {
           Cartlist cartlist = Carts.Where(r => r.Product.ProductId == details.ProductId).FirstOrDefault();
            if(cartlist == null)
            {
                cartlist = new Cartlist { Product=details,Quantity=quantity };

            }
            else
            {
                cartlist.Quantity += quantity;
            }
        }
        public virtual void Remove(Details details)
        {
            Carts.RemoveAll(r => r.Product.ProductId == details.ProductId);
        }
        public virtual decimal Sum()
        {
            return Carts.Sum(r => r.Product.Price * r.Quantity);
        }
        public virtual void Clear()
        {
            Carts.Clear();
        }
    }

    public class Cartlist
    {
        [Key]
        public int CartlineID { get; set; }
        public Details Product { get; set; }
        public int Quantity { get; set; }
    }
}
