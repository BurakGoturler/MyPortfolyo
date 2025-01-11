using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}