using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {

       // internal int[] Array1 = {2,4,9,12};
       // internal int[] Array2 = {1,3,7,10};

        public Class4()
        {

        }


        public void Multiply2Arrays(int[]Array1,int[]Array2)
        {
            int k = 0;
            int[] Array3 = new int[Array1.Length * Array2.Length];

            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    Array3[k] = Array1[i] * Array2[j];
                    Console.WriteLine(Array3[k]);
                    k++;
                }
            }


            

        }
    }
}
