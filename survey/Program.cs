using System;
using System.Collections.Generic;
namespace survey
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var students = new List<Student>();

           

            var adding = true;

            while (adding)

            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Add another? n/y");

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            
            {
                Console.WriteLine("Their name is {0} and their grade is {1}", student.Name, student.Grade);



            }
        }


    }
}

    class Student
    {
    static public int Count;

    public string Name;
    public int Grade;
    

    }
