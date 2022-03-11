using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public int Age { get; set; }

        public string Name;

        public Guid ID { get; }


        public Person()
        {
            ID = Guid.NewGuid(); 
        }


        public string GetName()
        {
            return Name;
        }


        public string SetName(string aName)
        {
           return Name = aName;
        }

    }   
}
