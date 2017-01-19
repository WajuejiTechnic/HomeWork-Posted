using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a sentence that you want to reverse");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int k = words.Length - 1;
            for (int i = k; i >=0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
