using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    public class Worker : Human
    {
        public int wage { get; set; }
        public int hoursWorked { get; set; }
   


        public Worker()
        {
        }

        public int CalculateHourlyWage(int wage, int hoursWorked)
        {
            int result = wage / hoursWorked;
            return result;
        }
    }


}
