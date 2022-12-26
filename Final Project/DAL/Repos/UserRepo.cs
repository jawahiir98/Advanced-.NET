using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User, int, bool>,IAuth<User, ShopUser>
    {
        Shop_CasketEntities db;
        public UserRepo()
        {
            db = new Shop_CasketEntities();
        }
        public bool Add(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Users.Remove(db.Users.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var temp = db.Users.Find(obj.Id);
            db.Entry(temp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public ShopUser Okay(User user)
        {
            var tmp = (from c in db.ShopUsers
                       where
                       user.Username == c.Username && user.Password == c.Password
                       select c
                       ).FirstOrDefault();
            if (tmp == null) return null;
            else return tmp;
        }


    }
}
