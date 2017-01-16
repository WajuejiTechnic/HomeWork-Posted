using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[n];
            string[] stringArray = new string[n];

            for (int j = 0; j < n; j++)
            {
                numArray[j] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Convert.ToString(numArray[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(stringArray[i] + " ");
            }
        }
    }
}
