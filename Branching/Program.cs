using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Test for Folk with Kyr and This");
                do
                {
                    Console.WriteLine($"3*3 = " + 3 * 3);
                } while (i == 4);


                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
