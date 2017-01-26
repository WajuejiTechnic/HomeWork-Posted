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
            Person person = new Person("John", 65, "Male");
           
            Console.WriteLine(person.GetAllInfo("John", 65, "Male"));
        }
    }
}
