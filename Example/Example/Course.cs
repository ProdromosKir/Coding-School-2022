using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        //public Student[] students = new Student[30];
        public string Code { get; set; }

        public string Subject { get; set; }

        public Guid ID { get; }
        public Course()
        {
          ID = Guid.NewGuid();  
        }

      

    }
}
