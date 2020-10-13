using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student Cokely = new Student("Cokely", 1234);

            Console.WriteLine("Student name: " + Cokely.Name);
            Console.WriteLine("Student ID: " + Cokely.StudentId);

            Cokely.AddGrade(30, 4.0);

            Console.WriteLine("Student grade: " + Cokely.NumberOfCredits);
            Console.WriteLine("Student GPA: " + Cokely.Gpa);
            Console.WriteLine(Cokely.ToString());
            Student Jonathan = new Student("Cokely", 1234);
            Jonathan.AddGrade(30, 4.0);
            Console.WriteLine(Cokely.Equals(Jonathan));
        }



    }
}
