using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public interface IOrder
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order p);
    }
}
