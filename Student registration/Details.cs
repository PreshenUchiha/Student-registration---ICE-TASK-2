using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_registration
{
    class Details
    {
        string StudentFullName;
        int StudentNumber;
        string Course;

        public Details(string studentFullName, int studentNumber, string course)
        {
            StudentFullName1 = studentFullName;
            StudentNumber1 = studentNumber;
            Course1 = course;
        }

        public string StudentFullName1 { get => StudentFullName; set => StudentFullName = value; }
        public int StudentNumber1 { get => StudentNumber; set => StudentNumber = value; }
        public string Course1 { get => Course; set => Course = value; }
    }
}
