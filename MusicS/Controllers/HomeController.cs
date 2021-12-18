using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MusicS.Models;


namespace MusicS.Controllers
{
    public class HomeController : Controller
    {
        private AppDBContext db;

        public HomeController(AppDBContext context)
        {
            db = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products;
            return View(products);
        }

        public IActionResult Question()
        {
            return View();
        }
        
        public IActionResult Contacts()
        {
            return View();
        }
    }
    
}
