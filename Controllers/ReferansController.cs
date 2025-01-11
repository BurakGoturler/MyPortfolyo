using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class ReferansController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ReferansList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        // Sayfa yüklendiğinde çalışacak olan metot
        [HttpGet]
        public IActionResult CreateReferans()
        {
            return View();
        }

        // Sayfada bir butona tıklandığında çalışacak olan metot
        [HttpPost]
        public IActionResult CreateReferans(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("ReferansList");
        }

        public IActionResult DeleteReferans(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReferansList");
        }

        [HttpGet]
        public IActionResult UpdateReferans(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateReferans(Testimonial testimonial)
        {
            var value = context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("ReferansList");
        }
    }
}