using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class OrderRepository : IOrder
    {
        private readonly SportsDbContext db;
        public OrderRepository(SportsDbContext db)
        {
            this.db = db;
        }
        public IQueryable<Order> Orders { get 
            {
               return db.Orders.Include(c=>c.Carts).ThenInclude(c=>c.Product);
            } 
        }

        public void SaveOrder(Order p)
        {
            db.Attach(p.Carts.Select(p => p.Product));
            if (p.OrderID == 0)
            {
                db.Orders.Add(p);

            }
            
            db.SaveChanges();
        }
    }
}
