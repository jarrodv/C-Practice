using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            PostgradStudent pS = new PostgradStudent();

            //Console.Write("Please enter: \n\nName: ");
            //s.setName(Console.ReadLine());
            //Console.Write("Student Number: ");
            //s.setStdNo(Console.ReadLine());
            //Console.Write("Address: ");
            //s.setAdd(Console.ReadLine());
            //Console.Write("Degree: ");
            //s.setDeg(Console.ReadLine());

            Console.Write("Please enter: \n\nName: ");
            pS.setName(Console.ReadLine());
            Console.Write("Student Number: ");
            pS.setStdNo(Console.ReadLine());
            Console.Write("Address: ");
            pS.setAdd(Console.ReadLine());
            Console.Write("Degree: ");
            pS.setDeg(Console.ReadLine());
            Console.Write("Dissertation: ");
            pS.setDis(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(pS.displayInfo(pS));
            Console.Read();
        }
    }
}
