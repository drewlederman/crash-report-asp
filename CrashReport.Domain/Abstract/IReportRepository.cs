using CrashReport.Domain.Entities;
using System.Linq;

namespace CrashReport.Domain.Abstract
{
    public interface IReportRepository
    {
        IQueryable<Report> GetReports();
    }
}
