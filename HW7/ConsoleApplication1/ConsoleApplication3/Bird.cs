using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Bird:Animal
    {
        private string feather;

        public Bird(string mouth, string leg, string feather):base(leg, mouth)
        {
            this.feather = feather;
        }

        public string Feather
        {
            get
            {
                return feather;
            }

            set
            {
                feather = value;
            }
        }

        public override string Bark()
        {
            return "GeeGee";
        }
    }
}
