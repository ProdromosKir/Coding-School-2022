using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string ID { get; set; } = Guid.NewGuid().ToString();


        public Person()
        {
           
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
