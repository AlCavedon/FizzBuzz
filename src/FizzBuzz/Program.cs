using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var msg = "0";
            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    msg = i + " (FizzBuzz)";
                }
                else if (i % 3 == 0)
                {
                    msg = i + " (Fizz)";
                }
                else if (i % 5 == 0)
                {
                    msg = i + " (Buzz)";
                }
                else
                {
                    msg = i.ToString();
                }
                Console.WriteLine(msg);
            }

            Console.Read();
        }
    }
}
