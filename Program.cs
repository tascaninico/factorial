using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int stop, number, fact = 1;

            Console.WriteLine("Enter an integer, that is >= 0 , factorial of which you would like to know:");

            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("factorial of {0} = 1", number);
                stop = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                for(int i = 1; i<=number; ++i) 
                    fact *= i; 
      
                Console.WriteLine("factorial of {0} = {1}", number, fact);
                stop = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}