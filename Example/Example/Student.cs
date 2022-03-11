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
        

        public Student()
        {

           
        }

        public void Attend(Course course,DateTime date)
        {

        }

        public void WriteExam(Course course, DateTime date)
        {

        }
    }
}
