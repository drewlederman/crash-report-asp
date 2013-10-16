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
                    Version = "1.0",
                    BinaryPath = "~/Files/Debug/DummyApp/1.0/DummyApp.exe",
                    SymbolPath = "~/Files/Debug/DummyApp/1.0/DummyApp.pdb"
                },
                new Application
                {
                    ApplicationId = 2,
                    Name = "DummyApp",
                    Version = "2.0",
                    BinaryPath = "~/Files/Debug/DummyApp/2.0/DummyApp.exe",
                    SymbolPath = "~/Files/Debug/DummyApp/2.0/DummyApp.pdb"
                },
                new Application
                {
                    ApplicationId = 3,
                    Name = "MyApp",
                    Version = "1.0",
                    BinaryPath = "~/Files/Debug/MyApp/1.0/MyApp.exe",
                    SymbolPath = "~/Files/Debug/MyApp/1.0/MyApp.pdb"
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
