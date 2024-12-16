using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prev1 = 0;
            int prev2 = 1;

            for (int i = 0; i < 18; i++)
            {
                int current = prev1 + prev2;
                Console.WriteLine(current);

                //Update the previous nummbers for the next iteration
                prev2 = prev1;
                prev1 = current;
            }
            Console.ReadKey();
        }
    }
}

