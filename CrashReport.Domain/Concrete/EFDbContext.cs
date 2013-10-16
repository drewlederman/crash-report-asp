using CrashReport.Domain.Entities;
using System.Data.Entity;

namespace CrashReport.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public DbSet<Report> Reports { get; set; }
    }
}
