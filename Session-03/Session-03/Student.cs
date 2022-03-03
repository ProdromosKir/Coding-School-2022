using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student :Person
    {

        public int RegistrationNumber { get; set; }
        public Course[] Courses;
        public String StudentId;

        public Student()
        {

            Guid ID = this.id;
        }

        public void Attend(Course aCourse,DateTime datetime)
        {

        }

        public void WriteExam(Course aCourse, DateTime datetime)
        {

        }
    }
}
