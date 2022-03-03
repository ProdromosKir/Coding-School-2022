using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        protected ushort Age { get; set; }

        protected string Name;

        public Guid id { get { return Guid.NewGuid(); } }


        public Person()
        {
            Guid ID = id;
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
