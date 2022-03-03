using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid ID { get { return Guid.NewGuid(); } }
        public string CourseID;
        public string ProffesorID;

        public DateTime Callendar;


        public Schedule()
        {
            //CourseID = Course.ID;
        }


       

        

    }
}
