using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Calculator
    {
        public double add(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public double add(double x, double y,double z)
        {
            double result = x + y+z;
            return result;
        }

        public double multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }

        public double multiply(double x, double y, double z)
        {
            double result = x * y*z;
            return result;
        }

        public double substract(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public double substract(double x, double y, double z)
        {
            double result = x - y-z;
            return result;
        }

        public double divide(double x, double y)
        {
            double result = x / y;
            return result;
        }

        public double divide(double x, double y, double z)
        {
            double result = x / y/z;
            return result;
        }
    }
}
