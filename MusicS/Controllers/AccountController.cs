using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using MusicS.Models;
using Microsoft.AspNetCore.Mvc;

namespace MusicS.Controllers
{
    public class AccountController : Controller
    {
        private AppDBContext db;
        private readonly IJWTAuthenticationManager jWTAuthenticationManager;

        public AccountController(AppDBContext context, IJWTAuthenticationManager jWTAuthenticationManager)
        {
            db = context;
            this.jWTAuthenticationManager = jWTAuthenticationManager;
        }
        
        [HttpPost]
        public IActionResult Registration(User model)
        {
            db.Add(model);
            db.SaveChanges();
            var token = jWTAuthenticationManager.Authenticate(model);
            Response.Cookies.Append("token", token);
            RedirectToAction("Profile", "Account");
            return RedirectToAction("Profile", "Account");
        }
        
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var currentUser = HttpContext.User;
            
            if (Request.Cookies["token"] == null || Request.Cookies["token"] == "")
            {
                return Redirect("/Account/registration");
            }
            var stream = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;

            var id = tokenS.Claims.First(claim => claim.Type == "nameid").Value;

            var user = db.Users.FirstOrDefault(u => u.UserId.ToString() == id);
            return View(user); // по токену возвращается аккаунт
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            if (Request.Cookies["token"] != null)
                return RedirectToAction("Profile", "Account");
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(User model)
        {
            User user = db.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if (user == null)
            {
                return RedirectToAction("Registration", "Account");
            }
            var token = jWTAuthenticationManager.Authenticate(user);

            if (token == null)
                return RedirectToAction("Login", "Account");
            else
            {
                Response.Cookies.Append("token", token);
                return RedirectToAction("Profile", "Account");
            }
        }

        public IActionResult LogOut()
        {
            var token = Request.Cookies["token"];
            if (token == null)
                return RedirectToAction("Registration", "Account");
            Response.Cookies.Delete("token");
            return Redirect("/");
        }
        
    }
}