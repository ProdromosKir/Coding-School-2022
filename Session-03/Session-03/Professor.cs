using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {

        public string Rank { get; set; }

        public Course[] Courses ;

        public Student Student;

        internal string studentID;
        internal string courseID;
        internal int grade;



        public Professor()
        {

        }

        public string GetName()
        {
            return "Dr." + Name;
        }

        public void Teach(Course Course,DateTime dateTime)
        {

        }

        public void SetGrade(string studentID,string courseID,int grade )
        {

        }
    }
}
