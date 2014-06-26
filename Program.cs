using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

    /* FizzBuzz Program.  Press CTRL + F5 to debug or run.  
      I assumed we wanted all the output at once and that the output "Divided by i for each number in collection by <lower number>" or 
      "Divided by i for each number in collction by <higher number> or by both numbers is the output.
      I used 5 as the lower number and 7 as the higher number*/

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 35 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    System.Console.WriteLine("Divided: " + i + " by: 35");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    System.Console.WriteLine("Divided: " + i + " by: 5"); 
                }
                else if (i % 7 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    System.Console.WriteLine("Divided: " + i + " by: 7");
                    
                }
                else if (i % 5 != 0|| i % 7 != 0 || i % 35 != 0)
                {
                    System.Console.WriteLine(i + " N/A");
                }
                    
            }
        }
    }
   
}
