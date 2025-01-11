using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}