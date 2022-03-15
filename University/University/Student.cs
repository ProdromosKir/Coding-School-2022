using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student : Person
    {

        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>(); 


        public Student()
        {


        }

        public void Attend(Course course, DateTime date)
        {

        }

        public void WriteExam(Course course, DateTime date)
        {

        }

        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }
    }
}
