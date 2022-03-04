using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {

        

        public Class5()
        {

        }

        public int[] BubbleSorting(int[]Array)
        {

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i+1; j < Array.Length; j++)
                {
                    if(Array[i]>Array[j])
                    {
                        int temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }

            return Array;
        }

        public void PrintSortedArray(int[]Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]+" ");
            }
        }

    }
}
