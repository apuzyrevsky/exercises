using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    public class Student : Human, IComparable<Student>
    {
        int mark { get; set; }

        public int CompareTo(Student other)
        {
            if (this.mark > other.mark) return -1;
            if (this.mark == other.mark) return 0;
            return 1;
        }



    }

}
