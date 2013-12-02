using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashReport.Domain.Entities
{
    public class ApplicationVersion
    {
        public int ApplicationVersionId { get; set; }
        public int ApplicationId { get; set; }
        public string Version { get; set; }
        public string DebugPath { get; set; }
    }
}
