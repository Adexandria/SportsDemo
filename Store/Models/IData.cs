using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
     public interface IData
    {
        IQueryable<Details> GetDetails { get; }
        void SaveProduct(Details p);
        void CreateProduct(Details p);
        void DeleteProduct(Details p);
    }
}
