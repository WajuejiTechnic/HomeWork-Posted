using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Cat:Animal
    {
        private string hunter;

        public Cat(string leg, string mouth, string hunter):base(leg, mouth)
        {
            this.hunter = hunter;
        }

        public string Hunter
        {
            get
            {
                return hunter;
            }

            set
            {
                hunter = value;
            }
        }

        public override string Bark()
        {
            return "Meow";
        }
    }
}
