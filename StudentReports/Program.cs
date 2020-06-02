using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReports
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report:");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are on: " + courseName);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpQuestion = Console.ReadLine();
            Console.WriteLine("You indicated: " + helpQuestion);
            Console.WriteLine("Was there any positive experiences you'd like to share? Please be specific:");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hourStudy = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
