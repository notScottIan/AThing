using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AThing
{
    class Engine
    {
        public List<Entry> Settings { get; set; } 
        
        public Engine() {
            Settings = new List<Entry>();
            ReadSettings();
        }

        public void ReadSettings() {

            string registryKey = "Software\\SHB\\AThing";            
            
            foreach (string registryValue in Registry.CurrentUser.OpenSubKey(registryKey).GetValueNames()) {
                string registryData = Registry.GetValue("HKEY_CURRENT_USER\\" + registryKey, registryValue, "").ToString();
                Settings.Add(new Entry(registryData.Split('|')[0], registryData.Split('|')[1]));
            }            
        }
    }
}
