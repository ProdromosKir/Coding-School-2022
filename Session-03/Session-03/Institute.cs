using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        protected string Name;
        public Guid ID { get { return Guid.NewGuid(); } }
        

        public int YearsInService { get; set; }





        public Institute()
        {
            Guid ID = this.ID;
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
