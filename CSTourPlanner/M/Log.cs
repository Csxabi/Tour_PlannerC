using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner.M
{
    public class Log
    {
        public int LogID { get; set; }
        public int TourID { get; set; }
        public int Rating { get; set; }
        public string Joule { get; set; }
        public string Torque { get; set; }
        public string Distance { get; set; }
        public string TotalTime { get; set; }
        public string Momentum { get; set; }
        public string Date { get; set; }
    }
}
