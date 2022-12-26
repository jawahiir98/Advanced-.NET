using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderItemsRepo : IRepo<Order_Items, int, bool>
    {
        Shop_CasketEntities db;
        public OrderItemsRepo()
        {
            db = new Shop_CasketEntities();
        }
        public bool Add(Order_Items obj)
        {
            db.Order_Items.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Order_Items.Remove(db.Order_Items.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Order_Items> Get()
        {
            return db.Order_Items.ToList();
        }

        public Order_Items Get(int id)
        {
            return db.Order_Items.Find(id);
        }

        public bool Update(Order_Items obj)
        {
            var temp = db.Order_Items.Find(obj.Id);
            db.Entry(temp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
