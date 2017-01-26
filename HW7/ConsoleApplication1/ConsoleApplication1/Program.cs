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
   
            Person person1 = new Person("China","Male","Asian");
            Console.WriteLine(person1.Nationality+person1.Gender+person1.Race);
        }
    }
}
