using BLL.DTOs;
using DAL.EF;
using DAL.Repos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        public static NewsDTO Assign(News n)
        {
            NewsDTO N = new NewsDTO();
            N.Id = n.Id;
            N.Title = n.Title;
            N.CategoryId = n.CategoryId;
            N.Date = n.Date;
            return N;
        }
        public static void Create(NewsDTO col)
        {

            News news = new News();
            news.Id = col.Id;
            news.Title = col.Title;
            news.CategoryId = col.CategoryId;
            news.Date = col.Date;
            new NewsRepo().Create(news);
        }
        public static NewsDTO Get(int id)
        {
            News n = new News();
            n = new NewsRepo().Get(id);
            NewsDTO news = Assign(n);
            return news;
        }
        public static List<NewsDTO> Get()
        {
            List<News> newslist = new NewsRepo().Get();
            List<NewsDTO> news = new List<NewsDTO>();
            foreach(var item in newslist)
            {
                NewsDTO newitem = Assign(item);
                news.Add(newitem);
            }
            return news;
        }
        public static void Remove(int id)
        {
            new NewsRepo().Remove(id);
        }
        public static void Update(NewsDTO col)
        {
            News news = new News();
            news.Id = col.Id;
            news.Title = col.Title;
            news.CategoryId = col.CategoryId;
            news.Date = col.Date;
            new NewsRepo().Update(news);
        }
    }
}
