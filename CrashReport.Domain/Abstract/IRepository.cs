using CrashReport.Domain.Entities;
using System.Linq;

namespace CrashReport.Domain.Abstract
{
    public interface IRepository
    {
        IQueryable<Application> GetApplications();

        IQueryable<Report> GetReports();
    }
}
