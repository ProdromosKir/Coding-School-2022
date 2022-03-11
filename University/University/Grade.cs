using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Grade
    {

        public Student Student;
        public Course Course;

        public Guid ID { get; }
        public Guid CourseID { get; set; }

        public Guid StudentID { get; set; }

        public int Value { get; set; }


        public Grade()
        {

            ID = Guid.NewGuid();
            //Guid ID = this.ID;
            //Guid StudentID = Student.id;
            //Guid CourseID = Course.ID;
        }

    }
}
