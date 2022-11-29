using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo : IRepo<News, int>
    {
        public void Create(News obj)
        {
            var db = new PortalEntities();
            db.News.Add(obj);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            var db = new PortalEntities();
            return db.News.ToList();
        }

        public News Get(int id)
        {
            var db = new PortalEntities();
            var ret = (from news in db.News where news.Id == id select news).FirstOrDefault();
            return ret;
        }

        public void Remove(int id)
        {
            var db = new PortalEntities();
            News news = new News();
            var ret = (from s in db.News where s.Id == id select s).FirstOrDefault();
            db.News.Remove(ret);
            db.SaveChanges();
        }

        public void Update(News obj)
        {   
            Remove(obj.Id);
            Create(obj);
        }
    }
}
