using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type how many numbers do you want to reverse: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type the character you want to reverse: ");
            string[] stringArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(stringArray[n - i - 1] + " ");
            }
        }
    }
}

