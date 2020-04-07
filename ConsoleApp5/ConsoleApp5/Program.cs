using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, middleName, lastName;
            firstName = Console.ReadLine();
            middleName = Console.ReadLine();
            lastName = Console.ReadLine();
            string fullName = GetFullName(firstName, middleName, lastName);
            Console.WriteLine(fullName);
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string middleName, string lastName)
        {
            string name = firstName + " " + middleName + " " + lastName;
            return name;
        }
    }

}
