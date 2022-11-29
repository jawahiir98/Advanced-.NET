using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public  ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult CreateNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNews(NewsDTO news)
        {
            NewsService.Create(news);
            return View();
        }
        public ActionResult GetNews()
        {
            List<NewsDTO> news = new List<NewsDTO>();
            news = NewsService.Get();
            return View(news);
        }
        public ActionResult UpdateNews(int Id)
        {
            NewsDTO news = new NewsDTO();
            news = NewsService.Get(Id);
            return View(news);
        }
        [HttpPost]
        public ActionResult UpdateNews(NewsDTO n)
        {
            NewsService.Update(n);
            return View("Dashboard");
        }
       
        public ActionResult RemoveNews(int n)
        {
            NewsService.Remove(n);
            return View("Dashboard");
        }
        
        public ActionResult ViewNews(int id)
        {
            NewsDTO news = NewsService.Get(id);
            return View(news);
        }
    }
}