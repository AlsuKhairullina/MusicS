using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MusicS.Controllers
{
    public class CategoriesController : Controller
    {
        
        private AppDBContext db;

        public CategoriesController(AppDBContext context)
        {
            db = context;
        }
        // GET
        [HttpGet]
        public IActionResult Guitars()
        {
            var guitars = db.Products.ToArray();
            return View(guitars);
        }
        [HttpGet]
        public IActionResult Keyboards()
        {
            var keyboards = db.Products.ToArray();
            return View(keyboards);
        }
        [HttpGet]
        public IActionResult Аccessories()
        {
            var accessories = db.Products.ToArray();
            return View(accessories);
        }
    }
}