using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GroupRepo : IRepo<Group,int ,bool>
    {
        BloodDonateEntities db;
        internal GroupRepo()
        {
            db = new BloodDonateEntities();
        }

        public bool Add(Group obj)
        {
            db.Groups.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var tmp = db.Groups.Find(id);
            db.Groups.Remove(tmp);
            return db.SaveChanges() > 0;
        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public bool Update(Group obj)
        {
            var tmp = db.Groups.Find(obj.Id);
            db.Entry(tmp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
