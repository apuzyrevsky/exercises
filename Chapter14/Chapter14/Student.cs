using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    public class Student
    {
        static int studentCount { get; set; }

        private string fullName { get; set; }
        private string course { get; set; }
        private string email { get; set; }
        private string phone { get; set; }


        enum University
        {
            MIT, Stanford, Harvard, Princeton, Yale
        }
        enum Subject
        {

        }

        public Student()
        {
            this.fullName = null;
            this.course = null;
            this.email = null;
            this.phone = null;

            studentCount += 1;


        }
        public void ShowStudentInfo()
        {
            Console.WriteLine(this.fullName);
            Console.WriteLine(this.course);
            Console.WriteLine(this.email);
            Console.WriteLine(this.phone);


        }



    }
}
