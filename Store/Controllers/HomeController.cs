using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Models;
using Store.Models.ViewsModel;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private IData data;
        private int pageSize = 4;
        public HomeController(IData data)
        {
            this.data = data;
        }

        public IActionResult Index(string category,int productPage = 1)
        {
            return View(new ProductsListModel
            {
                Products = data.GetDetails.Where(p => category == null || p.Category == category).OrderBy(m => m.ProductId).Skip((productPage - 1) * pageSize).Take(pageSize),
                PagingInfo = new PageInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ? data.GetDetails.Count() : data.GetDetails.Where(e => e.Category == category).Count()

                },
                Category = category
            }
            ) ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
