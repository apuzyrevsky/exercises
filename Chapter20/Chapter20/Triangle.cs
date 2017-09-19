using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    class Triangle : Shape
    {
        public override int CalculateSurface(int width, int height)
        {
            int result = (height * width / 2);
            return result;
        }
    }
}
