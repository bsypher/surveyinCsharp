using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the student's name?");
            var name = Tryagain();
            

                

            
            Console.WriteLine("What is their grade");
            var grade = Tryagain();
             

               
            

            var studentGrades = new int[] { };

            foreach (var studentGrade in studentGrades)
            {
                Console.Write(studentGrades);
            }



            Console.WriteLine("Their name is: {0} and their grade is {1}", name, grade);
          


        }
        static string Tryagain()
        {
            var answer = Console.ReadLine();
            if (answer == "")

            {
                Console.WriteLine("Enter the the requested data!");
                return Console.ReadLine();
            }
            return answer;
            else if ( answer == "quit")
            {
                Console.WriteLine("Take care lad");
                return Console.ReadLine();
            }
            
        }
    }
}
