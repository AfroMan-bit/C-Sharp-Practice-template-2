using Microsoft.EntityFrameworkCore;

namespace LizzardPirates.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<LizzardPirate> LizzardCrew { get; set; }
    }
}