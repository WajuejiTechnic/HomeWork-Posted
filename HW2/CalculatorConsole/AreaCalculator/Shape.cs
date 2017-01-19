using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Shape
    {
        
        public Shape(double width, double height)
        {
            double result = width * height;
        }

        public Shape(double radius)
        {
            double result = 3.1416 * radius*radius; 
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double GetCircleArea(double radius)
        {
            return radius * radius * 3.1416;
        }
        public override double GetRectangleArea(double width, double height)
        {
            return width * height;
        }


    }
}
