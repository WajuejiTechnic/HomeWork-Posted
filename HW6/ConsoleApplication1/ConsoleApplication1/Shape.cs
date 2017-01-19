using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Shape
    {
        public Shape(string name,double a, double b, double c, string color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.color = color;
            this.name = name;
        }

        public Shape(string name,double a, double b,string color)
        {
            this.a = a;
            this.b = b;
            this.color = color;
            this.name = name;
        }
        public Shape(string name,double a,string color)
        {
            this.a = a;
            this.color = color;
            this.name = name;
        }
        private double a;
        private double b;
        private double c;
        private string color;
        private string name;

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double GetArea(double a,double b,double c)
        {
            return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
        }
        public double GetArea(double a,double b)
        {
            return a * b;
        }
        public double GetArea(double a)
        {
            return a * a;
        }

        public double GetCircum(double a, double b, double c)
        {
            return a + b + c;
        }
        public double GetCircum(double a, double b)
        {
            return (a + b)*2;
        }
        public double GetCircum(double a)
        {
            return a*4;
        }
    }
}


