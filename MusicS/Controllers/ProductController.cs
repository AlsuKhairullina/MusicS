using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MusicS;
using MusicS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicS.Tools;

namespace MusicS.Controllers
{
    public class ProductController : Controller
    {
        private AppDBContext db;
        private readonly IJWTAuthenticationManager jWTAuthenticationManager;

        public ProductController(AppDBContext context, IJWTAuthenticationManager jWTAuthenticationManager, IWebHostEnvironment appEnvironment)
        {
            db = context;
            this.jWTAuthenticationManager = jWTAuthenticationManager;
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult AddItem(Product model)
        {
            var item = new Product()
            {
                ProductId  = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.Description,
                Price = model.Price,
                Category = model.Category
            };
            
            db.Products.Add(item);
            db.SaveChanges();
            return Redirect("/Home/Index");

        }
    }
}