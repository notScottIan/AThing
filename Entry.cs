using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AThing
{
    class Entry
    {        
        public string MonitoredDirectory { get; set; }
        public string MonitoredFileType { get; set; }
        public int FileCount { get; set; }

        public Entry(string monitoredDirectory, string monitoredFileType) {
            MonitoredDirectory = monitoredDirectory;
            MonitoredFileType = monitoredFileType;
            FileCount = 0;
        }

        public int CountFiles() {
            return Directory.GetFiles(MonitoredDirectory, MonitoredFileType).Length;
        }
    }
}
