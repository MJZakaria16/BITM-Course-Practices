using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Enter Number Between 40 to 100");
            mark = Convert.ToInt32(Console.ReadLine());
            string result = GetGrade(mark);
            Console.WriteLine("Your grade is {0}",result);
            Console.ReadKey();
        }

        static string GetGrade(int mark)
        {
            mark = mark / 10;
            string grade="";
            switch (mark)
            {
                case 4:
                    grade = "D";
                    break;
                case 5:
                    grade = "C";
                    break;
                case 6:
                    grade = "B";
                    break;
                case 7:
                    grade = "A";
                    break;
                case 8:
                    grade = "A+";
                    break;
                case 9:
                    grade = "A+";
                    break;
                case 10:
                    grade = "A+";
                    break;
                default:
                    Console.WriteLine("Failed");
                    break;
            }
            return grade;
        }
    }
}
