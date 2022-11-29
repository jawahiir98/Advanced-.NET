using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo : IRepo<Category, int>
    {
        public void Create(Category obj)
        {
            var db = new PortalEntities();
            db.Categories.Add(obj);
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            var db = new PortalEntities();
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            var db = new PortalEntities();
            return (from c in db.Categories where c.Id == id select c).FirstOrDefault(); 
        }

        public void Remove(int id)
        {
            var db = new PortalEntities();
            db.Categories.Remove((from c in db.Categories where c.Id == id select c).FirstOrDefault());
            db.SaveChanges();
        }

        public void Update(Category obj)
        {
            Remove(obj.Id);
            Create(obj);
        }
    }
}
