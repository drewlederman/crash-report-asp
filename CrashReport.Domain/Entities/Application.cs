using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrashReport.Domain.Entities
{
    public class Application
    {
        public int ApplicationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string IconFile { get; set; }

        public List<ApplicationVersion> Versions { get; set; }
    }
}
