using Microsoft.EntityFrameworkCore;
using FlipLoginAndRegister.Models;
namespace FlipLoginAndRegister
{
    public class AppDBContext:DbContext
    {
        public DbSet<UserData> UsersList { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
    }
}
