using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AThing
{
    class Engine
    {
        public List<Entry> Settings { get; set; } 
        
        public Engine() {
            Settings = new List<Entry>();
        }
    }
}
