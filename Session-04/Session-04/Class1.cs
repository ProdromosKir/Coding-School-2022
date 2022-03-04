using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {

        public string Name { get; set; }

        public Class1()
        {
            
        }

        

        public string ReverseString(string Name)
        {
            string reversedString = string.Empty;

            for (int i = Name.Length-1; i >= 0; i--)
            {
                reversedString += Name[i];
            }

            return reversedString;
        }
    }
}
