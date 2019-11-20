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
        public int CurrentCount {
            get {
                return Directory.GetFiles(MonitoredDirectory, MonitoredFileType).Length;
            }
        }

        public Entry(string monitoredDirectory, string monitoredFileType) {
            MonitoredDirectory = monitoredDirectory;
            MonitoredFileType = monitoredFileType;
        }
    }
}
