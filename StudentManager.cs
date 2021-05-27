using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Students");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNames = new String[studentCount];
            var studentGrades = new int [studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter Name of Student :");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine("Enter Student Grade :");
                studentGrades[i] = int.Parse(Console.ReadLine());


            }
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Student Name - {0} , Grade - {1}  ", studentNames[i],  studentGrades[i]);
                }
            
            }
    }
}
