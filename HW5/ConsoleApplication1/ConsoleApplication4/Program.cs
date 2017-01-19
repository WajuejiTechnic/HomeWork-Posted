using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Type a string with number inside: ");           
            //string num = Console.ReadLine();
            //switch(num)
            //{
            //    case "0":
            //        num = "zero";
            //        break;
            //    case "1":
            //        num = "one";
            //        break;
            //    case "2":
            //        num = "two";
            //        break;
            //    case "3":
            //        num = "three";
            //        break;
            //    case "4":
            //        num = "four";
            //        break;
            //    case "5":
            //        num = "five";
            //        break;
            //    case "6":
            //        num = "six";
            //        break;
            //    case "7":
            //        num = "seven";
            //        break;
            //    case "8":
            //        num = "eight";
            //        break;
            //    case "9":
            //        num = "nine";
            //        break;   
            //}

            //for (int i = 0; i < num.Length; i++)
            //{

            //}     

            Console.WriteLine("Type a string with number inside: ");
            string num = Console.ReadLine();
            num = num.Replace("1", "one").Replace("2", "two").Replace("3", "three").Replace("4", "four").Replace("5", "five").Replace("6", "six").Replace("7", "seven").Replace("8", "eight").Replace("9", "nine");
            Console.WriteLine(num);
        }
    }
}
