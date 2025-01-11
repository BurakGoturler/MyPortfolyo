using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();

            return View(values);
        }
    }
}