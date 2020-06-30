using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class SportRepository : IData
    {
        private readonly SportsDbContext db;
        public SportRepository(SportsDbContext db)
        {
            this.db = db;
        }
        public IQueryable<Details> GetDetails
        {
            get
            {
                return db.Details;
            }
        }

        public void CreateProduct(Details p)
        {
            db.Add(p);
            db.SaveChanges();
        }

        public void DeleteProduct(Details p)
        {
            db.Remove(p);
            db.SaveChanges();
        }

        public void SaveProduct(Details p)
        {
            db.SaveChanges();
        }
    }
}
