using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class PortfolyoController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult PortfolyoList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        // Sayfa yüklendiğinde çalışacak olan metot
        [HttpGet]
        public IActionResult CreatePortfolyo()
        {
            return View();
        }

        // Sayfada bir butona tıklandığında çalışacak olan metot
        [HttpPost]
        public IActionResult CreatePortfolyo(Portfolio portfolyo)
        {
            context.Portfolios.Add(portfolyo);
            context.SaveChanges();
            return RedirectToAction("PortfolyoList");
        }

        public IActionResult DeletePortfolyo(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolyoList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolyo(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolyo(Portfolio portfolyo)
        {
            var value = context.Portfolios.Update(portfolyo);
            context.SaveChanges();
            return RedirectToAction("PortfolyoList");
        }
    }
}