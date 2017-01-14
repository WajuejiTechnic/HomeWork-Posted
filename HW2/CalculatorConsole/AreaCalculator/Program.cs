using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine("What shape area do you want to calculate? circle or rectangle");
            string select= Console.ReadLine();
          
            if (select == "circle")
            {
                Console.WriteLine("Please Type the Radius: ");
                num1 = int.Parse(Console.ReadLine());
                Shape shape1 = new Shape(num1);
                shape1.Radius=num1;　
                Console.WriteLine("The Circle area is " + shape1.GetCircleArea(shape1.Radius));
            }
            
            if (select == "rectangle")
            {
                Console.WriteLine("Please Type the Height: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Type the Width: ");
                num3 = int.Parse(Console.ReadLine());
                Shape shape2 = new Shape(num2, num3);
                shape2.Height=num2;
                shape2.Width=num3;
                Console.WriteLine("The Rectangle area is " + shape2.GetRectangleArea(shape2.Height, shape2.Width));
            }
        }
    }
}
