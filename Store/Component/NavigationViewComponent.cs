using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Component
{
    public class NavigationViewComponent : ViewComponent {
        private readonly IData data;
        public NavigationViewComponent(IData data)
        {
            this.data = data;
        }
        public IViewComponentResult Invoke()

        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(data.GetDetails.Select(x => x.Category).Distinct().OrderBy(x => x));
        }
    }
}
