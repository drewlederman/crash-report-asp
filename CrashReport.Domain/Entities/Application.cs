using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashReport.Domain.Entities
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string BinaryPath { get; set; }
        public string SymbolPath { get; set; }
    }
}
