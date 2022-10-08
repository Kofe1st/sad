using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Base
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person1 = new Person("Matvey", "June", new DateTime(2002, 08, 02));
            var person2 = new Person("Matvey", "June", new DateTime(2002, 08, 02));

            Console.WriteLine(Object.ReferenceEquals(person2, person1));
            Console.WriteLine(person1 == person2);
            Console.WriteLine("хэш: \n{0}  \n{1}", person1.GetHashCode(), person2.GetHashCode());
            Console.WriteLine();
            var student = new Student(new Person("Matvey", "June", new DateTime(2004, 04, 08)), Education.Specialist, 320);
            student.AddExams(new Exam("\n TRiZBD", 5, new DateTime(2022, 09, 14)));
            student.AddTests(new Test("TRiZBD", true));
            Console.WriteLine(student.ToString());
            Console.WriteLine(student.Persons);
            Console.WriteLine();
            var studentClone = (Student)student.DeepCopy();
            student.Names = "Matvey";
            student.Surnames = "Paprikov";
            Console.WriteLine(student.ToString());
            Console.WriteLine(studentClone.ToString());


         
            try
            {
                student.GroupNumbers = 600;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            // С помощью оператора foreach для итератора, определенного в классе Student, вывести список всех зачетов и экзаменов. 
            foreach (var task in student.GetResults())
                Console.WriteLine(task.ToString());

            // С помощью оператора foreach для итератора с параметром, определенного в классе Student, вывести список всех экзаменов с оценкой выше 3.

            foreach (var task in student.ExamsOver(3))
                Console.WriteLine(task.ToString());
            Console.ReadKey();
        }
    }

    enum Education
    {
        Specialist,
        Вachelor,
        SecondEducation
    }


    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
}


