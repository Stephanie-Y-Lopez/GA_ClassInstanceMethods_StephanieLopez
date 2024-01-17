using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ClassInstanceMethods_StephanieLopez
{
    public class Student
    {
        //Properties
        public string Name { get; set; }
        public List<int> ExamScores { get; private set; }

        //Constructor to initalize students name and exam score
        public Student(string name)
        {
            Name = name;
            ExamScores = new List<int>();
        }

        //Constructor to take name and list of grades
        public Student(string name, List<int> examscores)
        {
            Name = name;
            ExamScores = examscores;
        }

        //Constructor for Adding Grades
        public void AddGrade(int grade)
        {
            // Only grades between 0 and 100 are accepted.
            if (grade >= 0 && grade <= 100)
            {
            ExamScores.Add(grade);
            Console.WriteLine($"Added grade {grade} for {Name}");
            }
            else
            {
            //Display the grade was not inputted.
            Console.WriteLine($"Invalid grade: {grade}. Grade must be between 0 and 100 please.");
            }

        }
        //Converts number into a letter part 1
        private char GetLetterGrade(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        //Converts a number into a letter part 2
        public void DisplayAllGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < ExamScores.Count; i++)
            {
                char letterGrade = GetLetterGrade(ExamScores[i]);
                Console.WriteLine($"Exam {i + 1}: {letterGrade} ({ExamScores[i]})");
            }
        }
        //Canculate the Average Score
        public double CalculateAverageScore()
        {
            if (ExamScores.Count == 0)
            {
                return 0;
            }

            int totalScore = 0;
            foreach (int score in ExamScores)
            {
                totalScore += score;
            }

            return (double)totalScore / ExamScores.Count;
        }

        public char GetGrade()
        {
            double averageScore = CalculateAverageScore();
            int roundedAverageScore = (int)Math.Round(averageScore);
            return GetLetterGrade(roundedAverageScore);
        }

        //Displays students information
        public void DisplayStudentInfo()
        {
            double averageScore = CalculateAverageScore();
            char grade = GetGrade();

            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Average Score: {averageScore:F2}");
            Console.WriteLine($"Grade: {grade}");
        }

    }
}
