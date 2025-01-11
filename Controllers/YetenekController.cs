using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class YetenekController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult YetenekList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        // Sayfa yüklendiğinde çalışacak olan metot
        [HttpGet]
        public IActionResult CreateYetenek()
        {
            return View();
        }

        // Sayfada bir butona tıklandığında çalışacak olan metot
        [HttpPost]
        public IActionResult CreateYetenek(Skill yetenek)
        {
            context.Skills.Add(yetenek);
            context.SaveChanges();
            return RedirectToAction("YetenekList");
        }

        public IActionResult DeleteYetenek(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("YetenekList");
        }

        [HttpGet]
        public IActionResult UpdateYetenek(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateYetenek(Skill yetenek)
        {
            var value = context.Skills.Update(yetenek);
            context.SaveChanges();
            return RedirectToAction("YetenekList");
        }
    }
}