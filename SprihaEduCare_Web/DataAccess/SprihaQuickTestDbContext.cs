using Microsoft.EntityFrameworkCore;
using SprihaEduCare_Web.Models;

namespace SprihaEduCare_Web.DataAccess
{
    public class SprihaQuickTestDbContext : DbContext
    {
        public SprihaQuickTestDbContext(DbContextOptions<SprihaQuickTestDbContext> options) : base(options) { }
        public DbSet<SprihaQuickTest> SprihaQuickTests { get; set; }
    }
}
