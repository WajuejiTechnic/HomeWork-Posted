using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Dog:Animal
    {
        private string paw;

        public Dog(string leg,string mouth, string paw):base(leg,mouth)
        {
            this.paw = paw;
        }

        public string Paw
        {
            get
            {
                return paw;
            }

            set
            {
                paw = value;
            }
        }

        public override string Bark()
        {
            return "Woof";
        }
    }
}
