using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private static int fibonacci;

        static void Main(string[] args)
        {
            Console.WriteLine("The order of the fibonacci number you want");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[n+1];
            if (n == 0)
            {
                fibonacci = 0;
            }
            if (n == 1)
            { 
                fibonacci = 1;
            }

            if (n > 1)
            {
                numArray[0] = 0;
                numArray[1] = 1;
                for (int i = 2; i < n+1; i++)
                {
                     
                    numArray[i]= numArray[i-1] + numArray[i-2];
                    fibonacci = numArray[i];
                }
            }
            Console.WriteLine("The " + n + "th fibonacci number is " + fibonacci);
        }
    }
}
