using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AThing
{
    internal class Entry
    {        
        internal string MonitoredDirectory { get; set; }
        internal string MonitoredFileType { get; set; }
        internal int FileCount { get; set; }

        internal Entry(string monitoredDirectory, string monitoredFileType) {
            MonitoredDirectory = monitoredDirectory;
            MonitoredFileType = monitoredFileType;
            FileCount = CountFiles();
        }

        internal int CountFiles() {

            int returnValue = 0;
            if (Directory.Exists(MonitoredDirectory)) {
                returnValue = Directory.GetFiles(MonitoredDirectory, MonitoredFileType).Length;
            }
            return returnValue;

        }

        internal bool UpdateCount() {

            bool countChanged = false;
            int newCount = CountFiles();
            if (FileCount != newCount) {
                FileCount = newCount;
                countChanged = true;
            }
            return countChanged;
        }
    }
}
