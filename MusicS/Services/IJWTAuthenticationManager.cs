using MusicS.Models;

namespace MusicS
{
    public interface IJWTAuthenticationManager
    {
        public string Authenticate(User model);
    }
}