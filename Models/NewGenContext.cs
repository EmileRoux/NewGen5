using Microsoft.EntityFrameworkCore;

namespace NewGen5Razor.Models
{
    public class NewGenContext : DbContext
    {
        public NewGenContext(DbContextOptions<NewGenContext> options)
                : base(options)
        {
        }

        public DbSet<Vendors> Vendors { get; set; }
    }
}