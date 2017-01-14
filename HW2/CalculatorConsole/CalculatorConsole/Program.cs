using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int select;
            Calculator calculator = new CalculatorConsole.Calculator();
            Console.WriteLine("How Many numbers do you want to calculate? 2 or 3");
            select = int.Parse(Console.ReadLine());

            if (select == 3)
            {
                Console.WriteLine("Please Type the First Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Type the Second Number: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Type the Third Number: ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type a Sign to calculate");
                char sign = (char)Console.Read();

                switch (sign)

                {
                    case '+':
                        double result1 = calculator.add(num1, num2, num3);
                        Console.WriteLine("The result is " + result1);
                        break;

                    case '-':
                        double result2 = calculator.substract(num1, num2, num3);
                        Console.WriteLine("The result is " + result2);
                        break;

                    case '*':
                        double result3 = calculator.multiply(num1, num2, num3);
                        Console.WriteLine("The result is " + result3);
                        break;
                    case '/':
                        double result4 = calculator.divide(num1, num2, num3);
                        Console.WriteLine("The result is " + result4);
                        break;
                }
                Console.ReadLine();
            }
         

            if (select == 2)
            {
                Console.WriteLine("Please Type the First Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Type the Second Number: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type a Sign to calculate");
                char sign = (char)Console.Read();

                switch (sign)
                {
                    case '+':
                        double result1 = calculator.add(num1, num2);
                        Console.WriteLine("The result is " + result1);
                        break;

                    case '-':
                        double result2 = calculator.substract(num1, num2);
                        Console.WriteLine("The result is " + result2);
                        break;

                    case '*':
                        double result3 = calculator.multiply(num1, num2);
                        Console.WriteLine("The result is " + result3);
                        break;
                    case '/':
                        double result4 = calculator.divide(num1, num2);
                        Console.WriteLine("The result is " + result4);
                        break;
                }
            }
        }
    }
}

