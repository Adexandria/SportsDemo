using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Infrastructure;
using Store.Models;

namespace Store.Pages
{
    public class CartModel : PageModel
    {
        private readonly IData data;
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public CartModel(IData data)
        {
            this.data = data;
        }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
         public IActionResult OnPost(long product,string returnUrl)
        {
            Details details = data.GetDetails.FirstOrDefault(p => p.ProductId == product);
            Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            Cart.Product(details, 1);
            HttpContext.Session.SetJson("cart",Cart);
            return RedirectToPage(new { returnUrl = returnUrl });

        }
    }
}
