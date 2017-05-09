using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Resources
{
    class Functions
    {
        public TimeSpan CalculateTravelTime(DateTime start, DateTime end)
        {
            return end.Subtract(start);
        }
        public List<Line> ReturnLinesThroughStation(String station)
        {
            List<Line> lines = new List<Line>();
            //...
            return lines;
        }
    }
}
