using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using todoAPI.Models;

namespace todoAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TodoModel> Todos {get; set; }

        // Declare Class Constructor
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) : base (options)
        {
            // Tobe implemented
        }
    }
}