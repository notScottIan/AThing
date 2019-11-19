using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AThing
{
    class Entry
    {        
        public string MonitoredDirectory { get; set; }
        public string MonitoredFileType { get; set; }
        public int CurrentCount { get; set; }

        public Entry(string monitoredDirectory, string monitoredFileType) {
            MonitoredDirectory = monitoredDirectory;
            MonitoredFileType = monitoredFileType;
            CurrentCount = 0;
        }
    }
}
