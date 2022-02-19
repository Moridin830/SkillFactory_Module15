using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var students_a = classes.Select(x => x.Students);
            List<string> vs = new List<string>();

            foreach (var currentList in students_a)
            {
                vs = vs.Concat(currentList).ToList();
            }

            return vs.ToArray();
        }

    }
}
