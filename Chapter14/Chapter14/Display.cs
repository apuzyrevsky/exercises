using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Display
    {
        string manufacturer { get; set; }
        string technology { get; set; }
        string resolution { get; set; }
        

        public Display(string manufacturer, string technology, string resolution)
        {
            this.manufacturer = manufacturer;
            this.technology = technology;
            this.resolution = resolution;
        }

    }
}
