using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type your Email: ");
            string email = Console.ReadLine();
            string userName;
            string domainName;
            int length;
            userName = email.Substring(0,email.IndexOf('@'));
            length = email.IndexOf('.')-email.IndexOf('@')-1;
            domainName = email.Substring(email.IndexOf('@') + 1,length);
            Console.WriteLine("My username is " + userName + ", " + "My domain name is " + domainName + ".");
        }
    }
}
