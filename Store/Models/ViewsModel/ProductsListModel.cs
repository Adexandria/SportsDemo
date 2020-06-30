using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.ViewsModel
{
    public class ProductsListModel
    {
        public IQueryable<Details> Products { get; set; } 
        public PageInfo PagingInfo { get; set; } 
        public string Category { get; set; }
    }
}

