using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class2
    {

        public int Number { get; set; }

        public Class2()
        {

        }

        public int SelectNumber()
        {
            Console.WriteLine("Give an integer: ");
            String stringNumber = Console.ReadLine();
            int number = Convert.ToInt32(stringNumber);

            return number;
        }

        


        public bool SumOrProduct()
        {
            

          Console.WriteLine("Type  0:Sum  1:Product");
          string stringNumber = Console.ReadLine();
          int number = Convert.ToInt32(stringNumber);

          if (number == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int CalculateSum(int number)
        {

            int sum = 0;

            while (number > 0)
            {
                sum += number;
                number--;
            }

            Console.WriteLine(sum);

            return number;
        }

        public int CalculateProduct(int number)
        {
            
            int product = 1;

            while (number > 1)
            {
                product = product * number;
                number--;
            }
            Console.WriteLine(product);

            return product;

          
        }
    }
}
