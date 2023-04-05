using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Class
{
    public class Student
    {
        public string studentid;
        public string name;

        public Student(string studentid, string name)
        {
            this.name = name;
            this.studentid = studentid;
        }
    }
}
