using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using MusicS.Models;
using Microsoft.AspNetCore.Http;

namespace MusicS.Tools
{
    public class Tool
    {
        private readonly IJWTAuthenticationManager jWTAuthenticationManager;
        private AppDBContext db;
        
        public Tool(AppDBContext context, IJWTAuthenticationManager jWTAuthenticationManager)
        {
            db = context;
            this.jWTAuthenticationManager = jWTAuthenticationManager;
        }
        public User FindUserByToken(HttpRequest request)
        {
            var stream = request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;
            var id = tokenS.Claims.First(claim => claim.Type == "nameid").Value;
            var user = db.Users.FirstOrDefault(u => u.UserId.ToString() == id);
            return user;
        }
    }
}