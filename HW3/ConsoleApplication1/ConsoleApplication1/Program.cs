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
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[n];
            int max = 0;

            for (int j = 0; j < n; j++)
            {
                numArray[j] = Convert.ToInt32(Console.ReadLine());
            }        

            for (int i = 0; i < n; i++)
            {
                if (numArray[i]>max)
                {
                    max = numArray[i];
                } 
            }
            Console.WriteLine(max);
        }
    }
}
