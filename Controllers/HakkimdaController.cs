using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class HakkimdaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult HakkimdaList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        // Sayfa yüklendiğinde çalışacak olan metot
        [HttpGet]
        public IActionResult CreateHakkimda()
        {
            return View();
        }

        // Sayfada bir butona tıklandığında çalışacak olan metot
        [HttpPost]
        public IActionResult CreateHakkimda(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("HakkimdaList");
        }

        public IActionResult DeleteHakkimda(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("HakkimdaList");
        }

        [HttpGet]
        public IActionResult UpdateHakkimda(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateHakkimda(About about)
        {
            var value = context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("HakkimdaList");
        }
    }
}
