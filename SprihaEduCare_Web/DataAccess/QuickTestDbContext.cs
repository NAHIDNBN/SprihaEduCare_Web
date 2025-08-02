using Microsoft.EntityFrameworkCore;
using SprihaEduCare_Web.Models;

namespace SprihaEduCare_Web.DataAccess
{
    public class QuickTestDbContext : DbContext
    {
        public QuickTestDbContext(DbContextOptions<QuickTestDbContext> options) : base(options) { }
        public DbSet<QuickTest> QuickTests { get; set; }
    }
}
