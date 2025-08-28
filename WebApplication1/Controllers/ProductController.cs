using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult index()
        {
            ViewData["Title"] = "list";
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewData["Title"] = $"detail - ID: {id}";
            ViewData["ProductId"] = id;
            return View();
        }
    }
}
