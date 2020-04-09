using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                string firstName, lastName, subject, result;
                int mark;
                Console.WriteLine("Enter first Name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter last Name:");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Subject:");
                subject = Console.ReadLine();
                Console.WriteLine("Enter Mark:");
                mark = Convert.ToInt32(Console.ReadLine());
                result = GetGrade(mark);
                if (mark > 40)
                {
                    Console.WriteLine("Hello {0} {1}.Congratulation! " +
                                      "You have passe in {2} and" +
                                      " your grade is {3}", firstName, lastName, subject, result);
                }
                else if (mark < 40)
                {
                    Console.WriteLine("Sorry! You have failed. Please try again!");
                }

                Console.WriteLine("Do you want to continue (y/n)?");
                ch = Convert.ToChar(Console.ReadLine());
                
            } while (ch == 'y' || ch == 'Y');
        }

        static string GetGrade(int mark)
        {
            mark = mark / 10;
            string grade = "";
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
                
            }
            return grade;
        }
    }
}
