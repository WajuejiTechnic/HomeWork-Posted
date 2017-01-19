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
            double TriArea;
            double TriCum;
            double RecArea;
            double RecCum;
            double SqArea;
            double SqCum;
            double maxArea;
            double maxCum;

            Shape shape = new Shape("Triangle", 2, 3, 4, "blue");
            TriArea = shape.GetArea(2, 3, 4);
            TriCum = shape.GetCircum(2, 3, 4);

            Shape shape1 = new Shape("Rectangle", 4, 3, "blue");
            RecArea = shape1.GetArea(4, 3);
            RecCum = shape1.GetCircum(4, 3);

            Shape shape2 = new Shape("Square", 5, "red");
            SqArea = shape2.GetArea(5);
            SqCum = shape2.GetCircum(5);
            maxArea = Math.Max(TriArea, Math.Max(RecArea, SqArea));
            maxCum = Math.Max(TriCum, Math.Max(RecCum, SqCum));

            if (maxArea == TriArea)
            {
                Console.WriteLine(Convert.ToString(maxArea) + " " + shape.Name + " " + shape.Color);
            }
            if (maxArea == RecArea)
            {
                Console.WriteLine(Convert.ToString(maxArea) + " " + shape1.Name + " " + shape1.Color);
            }
            if (maxArea == SqArea)
            {
                Console.WriteLine(Convert.ToString(maxArea) + " " + shape2.Name + " " + shape2.Color);
            }
            if (maxCum == TriCum)
            {
                Console.WriteLine(Convert.ToString(maxCum) + " " + shape.Name + " " + shape.Color);
            }
            if (maxCum == RecCum)
            {
                Console.WriteLine(Convert.ToString(maxCum) + " " + shape1.Name + " " + shape1.Color);
            }
            if (maxCum == SqCum)
            {
                Console.WriteLine(Convert.ToString(maxCum) + " " + shape2.Name + " " + shape2.Color);
            }
        }
    }
}

