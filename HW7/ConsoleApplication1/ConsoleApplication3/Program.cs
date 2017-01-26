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
            List<Animal> animallist = new List<Animal>();
            animallist.Add(new Bird("sharp", "sharp", "color"));
            animallist.Add(new Dog("short", "big", "thick"));
            animallist.Add(new Cat("fairy", "small", "aggressive"));
            Animal bark = new Bird("sharp", "sharp", "color");
            Console.WriteLine(bark.Bark());
        }
    }
}
