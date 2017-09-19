using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    public abstract class Shape
    {
        public int width { get; set; }
        public int height { get; set; }


        public abstract int CalculateSurface(int width, int height);
       

    }



}
