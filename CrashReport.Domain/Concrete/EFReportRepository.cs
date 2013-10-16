using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrashReport.Domain.Abstract;
using CrashReport.Domain.Entities;

namespace CrashReport.Domain.Concrete
{
    public class EFReportRepository : IReportRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Report> GetReports()
        {
            return context.Reports;
        }
    }
}
