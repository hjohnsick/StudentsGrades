using System;

namespace StudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the percentage value for the student's grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("You got an A!  Excellent Job!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B!  Good job!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You got a C.  You passed.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got a D.  Study harder");
            }
            else
            {
                Console.WriteLine("You failed.");
            }
        }
    }
}
