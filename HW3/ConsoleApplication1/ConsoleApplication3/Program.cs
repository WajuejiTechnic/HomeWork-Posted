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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                stringArray[i]=Convert.ToString(Console.ReadLine()); 
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(stringArray[j] + "-");
            }
        }
    }
}
