using CrashReport.Domain.Abstract;
using CrashReport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashReport.Domain.Concrete
{
    public class DummyReportRepository : IReportRepository
    {
        private List<Report> reports;

        public DummyReportRepository()
        {
            reports = new List<Report>();

            reports.Add(new Report
            {
                AppName = "DummyApp",
                AppVersion = "1.0",
                Description = "It just crashed, I dunno!",
                FilePath = "~/Files/Crash.dmp",
                FromIP = "192.168.0.1",
                StackTrace = "DummyApp::UnhandledException()\rDummyApp::DoSomething()\nDummyApp::Main()",
                TimeStamp = DateTime.Now
            });

            reports.Add(new Report
            {
                AppName = "DummyApp",
                AppVersion = "2.0",
                Description = "",
                FilePath = "~/Files/Crash.dmp",
                FromIP = "192.168.0.1",
                StackTrace = "DummyApp::UnhandledException()\rDummyApp::DoSomething()\nDummyApp::Main()",
                TimeStamp = DateTime.Now
            });

            reports.Add(new Report
            {
                AppName = "MyApp",
                AppVersion = "1.0",
                Description = "It's like this app was designed to crash or something.",
                FilePath = "~/Files/Crash.dmp",
                FromIP = "192.168.0.1",
                StackTrace = "MyApp::UnhandledException()\rMyApp::DoSomething()\nMyApp::Main()",
                TimeStamp = DateTime.Now
            });
        }

        public IQueryable<Report> GetReports()
        {
            return reports.AsQueryable();
        }
    }
}
