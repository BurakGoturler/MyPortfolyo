using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}