using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public Class3()
        {

        }

        public int SelectNumber()
        {
            Console.WriteLine("Give me an integer: ");
            string stringNumber = Console.ReadLine();
            int number = Convert.ToInt32(stringNumber);
            return number;
        }


        public void FindingPrimes(int number)
        {
            Console.WriteLine("Primes for {0}", number+ " are");

            for (int i = 2; i < number; i++)
            {
                if (number % i != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------------------------");
        }

    }

    

}
