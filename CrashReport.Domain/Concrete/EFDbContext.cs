using CrashReport.Domain.Entities;
using System.Data.Entity;

namespace CrashReport.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }
    }
}
