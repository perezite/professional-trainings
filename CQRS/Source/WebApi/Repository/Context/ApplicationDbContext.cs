using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Entities.User;

namespace WebApi.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User>? Users{ get; set; }
    }
}
