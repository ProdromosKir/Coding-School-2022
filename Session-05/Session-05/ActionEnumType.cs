using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
   

        public enum ActionEnumType
        {
            Convert,
            Uppercase,
            Reverse
        }

    internal class ActionEnum
    {


        public string Convert(string input)
        {
            decimal decimalNumber;

          
            if (Decimal.TryParse(input, out decimalNumber))
            {

                int number = int.Parse(input);
                string binary = System.Convert.ToString(number, 2);

                return binary;


            }
            else
            {
                //message
                return null;
                Console.WriteLine("Unable");
            }






            //decimal decimalNumber;
            //if (Decimal.TryParse(input, out decimalNumber))
            //{

            //    int number = int.Parse(input);
            //    string binary = System.Convert.ToString(number, 2);

            //    return binary;


            //}
            //else
            //{
            //    //message
            //    Console.WriteLine("Unable");
            //}
        }




        public string Uppercase(string input)
        {
           
            string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
            string upperCaseWord = word.ToUpper();
            return upperCaseWord;
        }


        public string ReverseString(string input)
        {
                string reversedString = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedString += input[i];
                }

                return reversedString;
            
        }

    }

    
}
