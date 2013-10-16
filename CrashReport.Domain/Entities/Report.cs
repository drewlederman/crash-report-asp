using System;

namespace CrashReport.Domain.Entities
{
    public class Report
    {
        public int ReportId { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string StackTrace { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string FromIP { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
