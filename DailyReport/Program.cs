using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning of Code 
            Console.WriteLine("Academy of Learning Career College.");
            Console.WriteLine("Student Daily Report");

            //String components
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Converting interger to a string
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            //Converting a string to a boolean
            Console.WriteLine("Do you need help with anything? Answer with \'true\' or \'false\'.");
            string help = Console.ReadLine();
            bool helpBool = bool.Parse(help);

            //More String components
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Integer Component (string -> integer)
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);

            //Message after everything has been filled out!
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

           
        }
    }
}
