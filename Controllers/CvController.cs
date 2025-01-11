using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace MyPortfolyo.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult DownloadCV()
        //{
        //    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "BurakCV.pdf");
        //    string contentType = "application/pdf";
        //    string fileName = "BurakCV.pdf";

        //    if (System.IO.File.Exists(filePath))
        //    {
        //        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        //        return File(fileBytes, contentType, fileName);
        //    }
        //    else
        //    {
        //        return NotFound("Dosya bulunamadı.");
        //    }
        //}

        public IActionResult ViewCV()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CV", "BurakCV.pdf");
            if (System.IO.File.Exists(filePath))
            {
                return new FileStreamResult(System.IO.File.OpenRead(filePath), "application/pdf");
            }
            else
            {
                return NotFound("Dosya bulunamadı.");
            }
        }
    }
}