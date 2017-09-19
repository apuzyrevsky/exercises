using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    public class Worker : Human
    {
        public int Wage { get; set; }
        public int HoursWorked { get; set; }
   


        public Worker()
        {
        }

        public int CalculateHourlyWage(int Wage, int HoursWorked)
        {
            int result = Wage / HoursWorked;
            return result;
        }
    }


}
