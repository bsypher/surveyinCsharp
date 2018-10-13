using System;
using System.Collections.Generic;
namespace survey
{
    class Program
    {
        private static int studentAmount;

        static void Main(string[] args)
        {
            
            var studentName = new List<string>();
            var studentGrade = new List<int>();

            var adding = true;

            while (adding)

            {
                Console.Write("What is the student's name?");
                studentName.Add(Console.ReadLine());

                Console.Write("What is the student's grade?");
                studentGrade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? n/y");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            for (int i = 0; i < studentName.Count; i++)
            {
                Console.WriteLine("Their name is {0} and their grade is {1}", studentName[i], studentGrade[i]);



            }
        }


    }
}