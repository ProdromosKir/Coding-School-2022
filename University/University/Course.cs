using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Course
    {

        public string Code { get; set; }

        public string Subject { get; set; }

        public string ID { get; } = Guid.NewGuid().ToString();  
        public Course()
        {
            
        }
    }
}
