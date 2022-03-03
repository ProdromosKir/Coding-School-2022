using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {

        public Student Student;
        public Course Course;

        public Guid ID { get { return Guid.NewGuid(); } }
        public Guid CourseID { get; set;}

        //public int Value { get; set; }
        public int Grade_ { get; set; }

        public Grade()
        {
            Guid ID = this.ID;
            Guid StudentID = Student.id;
            Guid CourseID = Course.ID;
        }

    }
}
