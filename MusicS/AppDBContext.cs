using Microsoft.EntityFrameworkCore;
using MusicS.Models;

namespace MusicS
{
    public class AppDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
    }
}