using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            while (true)
            {
                Console.WriteLine("Please Type an positive integer, type End when finished");
                string num = Console.ReadLine();
                if (num == "End")
                {
                    Console.WriteLine("The max value is {0}", max);
                    return;
                }
                int n = Convert.ToInt32(num);
                if (n > max)
                {
                    max = n;
                }
            }
        }
    }
}