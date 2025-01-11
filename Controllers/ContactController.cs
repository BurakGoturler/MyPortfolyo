using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;
using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }

        // Sayfa yüklendiğinde çalışacak olan metot
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        // Sayfada bir butona tıklandığında çalışacak olan metot
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact testimonial)
        {
            var value = context.Contacts.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}