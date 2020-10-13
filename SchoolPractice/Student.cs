using System;
using System.Xml.Schema;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            
            Gpa = ((Gpa*NumberOfCredits)+(grade*courseCredits))/(NumberOfCredits+courseCredits);
            NumberOfCredits += courseCredits;


        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            string GradeLevel = "grade level tbd";
            // Determine the grade level of the student based on NumberOfCredits
            if(credits < 29)
            { 
                GradeLevel = "Freshman";
            }

            if(credits >= 30 && credits < 59)
            { 
                GradeLevel = "Sophomore";
            }

            if(credits >= 60 && credits < 89)
            { 
                GradeLevel = "Junior";
            }

            if(credits > 90)
            {
                GradeLevel = "Senior";
            }

            return GradeLevel;
        }

        public override string ToString()
        {
            return Name + "(Credits: " + NumberOfCredits + " )";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.



        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
