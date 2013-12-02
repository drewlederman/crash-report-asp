using CrashReport.Domain.Abstract;
using CrashReport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashReport.Domain.Concrete
{
    public class DummyRepository : IRepository
    {
        public IQueryable<Application> GetApplications()
        {
            return new List<Application>
            {
                new Application
                {
                    ApplicationId = 1,
                    Name = "DummyApp",
                    IconFile = "Default.png",
                    Versions = new List<ApplicationVersion>
                    {
                        new ApplicationVersion
                        {
                            ApplicationId = 1,
                            ApplicationVersionId = 1,
                            Version = "1.0",
                            DebugPath = "~/Files/Apps/1/1/"
                        }
                    }
                },
                new Application
                {
                    ApplicationId = 2,
                    Name = "MyApp",
                    IconFile = "Default.png",
                    Versions = new List<ApplicationVersion>
                    {
                        new ApplicationVersion
                        {
                            ApplicationId = 2,
                            ApplicationVersionId = 1,
                            Version = "1.0",
                            DebugPath = "~/Files/Apps/2/1/"
                        }
                    }
                }
            }.AsQueryable();
        }

        public IQueryable<Report> GetReports()
        {
            return new List<Report>
            {
                new Report
                {
                    ReportId = 1,
                    AppName = "DummyApp",
                    AppVersion = "1.0",
                    Description = "It just crashed, I dunno!",
                    FilePath = "~/Files/Crash.dmp",
                    FromIP = "192.168.0.1",
                    StackTrace = "DummyApp::UnhandledException()\rDummyApp::DoSomething()\nDummyApp::Main()",
                    TimeStamp = DateTime.Now
                },
                new Report
                {
                    ReportId = 2,
                    AppName = "DummyApp",
                    AppVersion = "2.0",
                    Description = "",
                    FilePath = "~/Files/Crash.dmp",
                    FromIP = "192.168.0.1",
                    StackTrace = "DummyApp::UnhandledException()\rDummyApp::DoSomething()\nDummyApp::Main()",
                    TimeStamp = DateTime.Now
                },
                new Report
                {
                    ReportId = 3,
                    AppName = "MyApp",
                    AppVersion = "1.0",
                    Description = "It's like this app was designed to crash or something.",
                    FilePath = "~/Files/Crash.dmp",
                    FromIP = "192.168.0.1",
                    StackTrace = "MyApp::UnhandledException()\rMyApp::DoSomething()\nMyApp::Main()",
                    TimeStamp = DateTime.Now
                }
            }.AsQueryable(); 
        }
    }
}
