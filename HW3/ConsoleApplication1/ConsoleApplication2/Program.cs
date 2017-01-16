using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[n];
            

            for (int j = 0; j < n; j++)
            {
                numArray[j] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                
                sum = numArray[i] + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
