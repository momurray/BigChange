using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BigChange.General;

namespace BigChange
{
    class Program
    {
        static void Main(string[] args)
        {
            //without altering any of the code in Main() write code in this fiddle that satisfies the two examples below: 

            Console.WriteLine("(1)\t====== Remove Extra Chars ======"
                              + "\n\n\t\tReturn a string where the number of consecutive characters of the same value is limited to the parameter supplied\n");

            //should return "aaabbbcccd
            Console.WriteLine("aaaaaaaabbbbbccccccd".RemoveConsecutiveChars(3));

            //should return "aabbccdd"
            Console.WriteLine("aaabbcccccdddd".RemoveConsecutiveChars(2));

            Console.WriteLine("\n\n(2)\t====== Fizz Buzz ======"
                              + "\n\n\t\tShould return each number between zero and its parameter but replaces multiples of 3 with 'Fizz' and multiples of 5 with 'Buzz'"
                              + "\n\n\t\tWhere the number of 'z' characters each word is the same as the other factor of the input number"
                              + "\n\n\t\tFor multiples of both 3 and 5 replace the number with both of the corresponding 'Fizz'-'Buzz' words. eg 15=\"Fizzzzz-Buzzz\"\n");

            // I like this kind of return:
            //
            //  Concrete result (boolean)
            //  Data (if ok)
            //  Meaningful error message when not ok. 
            //
            (bool bResult, List<string> listOutput, string Message) = FizzBuzz.Calculate(37, 4, 6);
            Console.WriteLine(Message);

            if (bResult)
            {
                foreach (var s in listOutput)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey(true);
        }
    }

}
