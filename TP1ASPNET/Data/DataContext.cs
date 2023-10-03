using Microsoft.EntityFrameworkCore;
using TP1ASPNET.Models;

namespace TP1ASPNET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Livre> Livre { get; set; }
    }
}
