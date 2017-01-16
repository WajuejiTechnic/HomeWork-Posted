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
            Console.WriteLine("Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Password");
            string passWord = Console.ReadLine();

            while (userName!="Hello"||passWord!="123")
            {
                Console.WriteLine("Please Type again");
                userName = Console.ReadLine();
                passWord = Console.ReadLine();
            }
            Console.WriteLine("Succeed!");
        }
    }
}
