using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentManager
    {

        public List<Student> Students { get; set; }

        public StudentManager()
        {
            Students = new List<Student>();
        }

        public Student AddStudent()
        {
            return AddStudent("{enter name}", 0);
        }

        public Student AddStudent(string name)
        {
            return AddStudent(name, 0);
        }

        public Student AddStudent(string name,int age)
        {
            Student student = new Student()
            {
                Name = name,
                Age = age,
            };

           
            
            Students.Add(student);
            
            
            return student;
        }
    }
}
