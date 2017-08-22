
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Call
    {
        string caller { get; set; }
        string date { get; set; }
        string timeOfStart { get; set; }
        string duration { get; set; }






        public Call(string caller, string date, string timeOfStart, string duration)
        {
            this.caller = caller;
            this.date = date;
            this.timeOfStart = timeOfStart;
            this.duration = duration;
        }

    }
  
}
