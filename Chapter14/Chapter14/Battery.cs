using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    public class Battery
    {
        string model { get; set; }
        string capacity { get; set; }
        enum BatteryType
        {
            LiIon, NiMH, NiCd, ColdFusion
        }

       public Battery(string model, string capacity)
        {
            this.model = model;
            this.capacity = capacity;
        }




  
    }
}
