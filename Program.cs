using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Teacher teacher = new Teacher();

            Console.WriteLine("User selection options: 1=student 2=teacher");
            Console.Write("Please enter your user type: ");
            string userType = Console.ReadLine();


            switch (userType)
            {
                case "1":
                case "student":
                    Console.WriteLine("Enter the student's first name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter the student's last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter the student's birthday: ");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
                    Console.ReadLine();
                    break;

                case "2":
                case "teacher":
                    Console.WriteLine("Enter the teacher's first name? ");
                    teacher.teacherName = Console.ReadLine();
                    Console.WriteLine("What course do you teach? ");
                    teacher.course = Console.ReadLine();
                    Console.WriteLine("What is your program? ");
                    teacher.program = Console.ReadLine();
                    Console.WriteLine("What degree? ");
                    teacher.degree = Console.ReadLine();

                    Console.WriteLine("{0} teaches {1} for the {2} program, which offers a {3} degree", teacher.teacherName, teacher.course, teacher.program, teacher.degree);
                    Console.ReadLine();
                    break;
            }


            }
    }
}
