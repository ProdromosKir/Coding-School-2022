using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
       public Student[] Students = new Student[30];
       public  Course[] Courses = new Course[20];
       public Professor[] Professors = new Professor[5];
       public Schedule[] ScheduledCourses = new Schedule[60];
       
       public Grade[] Grades;

        public University()
        {
            
        }


        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourses()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }


        public void SetSchedule(string CourseID,String ProffesorID,DateTime dateTime)
        {

        }

    }
}
