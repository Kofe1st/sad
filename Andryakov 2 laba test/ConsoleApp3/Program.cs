// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Person per1 = new Person("qwe", "rty", new DateTime(2004, 11, 30));
Person per2 = new Person("qwe", "rty", new DateTime(2004, 11, 30));
Console.WriteLine(per1.GetHashCode());
Console.WriteLine(per2.GetHashCode());

//Student stud1 = new Student(Education.Specialist, 105, new Test("math", true), new Exam("PE",4, new DateTime(2015,11,23)) );

