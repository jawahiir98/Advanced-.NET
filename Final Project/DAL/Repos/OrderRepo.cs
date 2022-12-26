using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : IRepo<Order, int, bool>
    {
        Shop_CasketEntities db;
        public OrderRepo()
        {
            db = new Shop_CasketEntities();
        }
        public bool Add(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Orders.Remove(db.Orders.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public bool Update(Order obj)
        {
            var temp = db.Orders.Find(obj.Id);
            db.Entry(temp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
