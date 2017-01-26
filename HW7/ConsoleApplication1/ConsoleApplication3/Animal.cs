using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Animal
    {
        private string leg;
        private string mouth;

        public Animal(string leg, string mouth)
        {
            this.leg = leg;
            this.mouth = mouth;
        }

        public string Leg
        {
            get
            {
                return leg;
            }

            set
            {
                leg = value;
            }
        }

        public string Mouth
        {
            get
            {
                return mouth;
            }

            set
            {
                mouth = value;
            }
        }
        public virtual string Bark()
        {
            return "Wow";
        }
    }
}
