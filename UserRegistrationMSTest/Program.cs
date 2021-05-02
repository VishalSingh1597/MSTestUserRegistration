using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To UserRegistrationMSTest-----");
            Console.WriteLine();

            UserDetail pattern = new UserDetail();// crating object of userdetail class

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));


            Console.Read();
        }
    }
}