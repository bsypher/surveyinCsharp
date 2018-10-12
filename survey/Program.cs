using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the class size?");
            var studentAmount = int.Parse(Console.ReadLine());
            var studentName = new string[studentAmount];
            var studentGrade = new int[studentAmount];


            for (int i = 0; i < studentAmount; i++)
            {
                Console.Write("What is the student's name?");
                studentName[i] = Console.ReadLine();

                Console.Write("What is the student's grade?");
                studentGrade[i] = int.Parse(Console.ReadLine());


            }

            for (int i = 0; i < studentAmount; i++)
            {
                Console.WriteLine("Their name is: {0} and their grade is {1}", studentName[i], studentGrade[i]);



            }
        }
    }

}

    
