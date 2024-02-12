using Microsoft.EntityFrameworkCore;
using RazorProject.Models.Domain;

namespace RazorProject.Data
{
    public class RazorAppDbContext : DbContext
    {
        public RazorAppDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Book> Books { get; set; }
    }
}
