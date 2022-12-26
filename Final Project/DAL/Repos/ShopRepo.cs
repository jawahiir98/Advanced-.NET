using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ShopRepo : IRepo<ShopUser, int, bool>
    {
        Shop_CasketEntities db;
        internal ShopRepo()
        {
            db = new Shop_CasketEntities();
        }
        public bool Add(ShopUser obj)
        {
            db.ShopUsers.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.ShopUsers.Remove(db.ShopUsers.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<ShopUser> Get()
        {
            return db.ShopUsers.ToList();
        }

        public ShopUser Get(int id)
        {
            return db.ShopUsers.Find(id);
        }

        public bool Update(ShopUser obj)
        {
            var temp = db.ShopUsers.Find(obj.Id);
            db.Entry(temp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
