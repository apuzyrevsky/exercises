using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
{
    public class Student : Human, IComparable<Student>
    {
       public int Mark { get; set; }

        public int CompareTo(Student other)
        {
            return other.Mark.CompareTo(this.Mark); // ascending order, change other to this to do descending
        }



    }

}
