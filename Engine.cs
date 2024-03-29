﻿using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;

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

            if (Registry.CurrentUser.OpenSubKey(registryKey) != null) {
                foreach (string registryValue in Registry.CurrentUser.OpenSubKey(registryKey).GetValueNames()) {
                    string registryData = Registry.GetValue("HKEY_CURRENT_USER\\" + registryKey, registryValue, "").ToString();
                    string addDirectory = registryData.Split('|')[0];
                    string addType = registryData.Split('|')[1];
                    if (Directory.Exists(addDirectory)) {
                        Settings.Add(new Entry(addDirectory, addType));
                    }
                }
            }
        }        
    }
}
