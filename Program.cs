namespace GA_ClassInstanceMethods_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static void Main(string[] args)
        {
            // Create a list of 5 grades ranging between 0 and 100
            List<int> StephanieGrades = new List<int> { 82, 74, 88, 91, 100 };

            // Create a new instance of the Student class with the name "Will" and the grades list
            Student StephanieStudent = new Student("Stephanie", StephanieGrades);

            StephanieStudent.AddGrade(99); //Should Work
            StephanieStudent.AddGrade(-2); //Shouldn't Work
            StephanieStudent.AddGrade(150); //Shouldn't Work
            Console.WriteLine("");
            StephanieStudent.DisplayAllGrades();
            Console.WriteLine("");
            StephanieStudent.GetGrade();
            Console.WriteLine("");
            StephanieStudent.DisplayStudentInfo();
            Console.WriteLine("");
            Console.WriteLine("");

            //Adding code required part 1
            static List<Student> GenerateRandomStudents()
            {
                List<Student> students = new List<Student>();
                Random random = new Random(); // Random object created here

                for (int i = 1; i <= 5; i++)
                {
                    Student student = new Student($"Student{i}");

                    for (int j = 0; j < 5; j++)
                    {
                        student.ExamScores.Add(random.Next(0, 101));
                    }

                    students.Add(student);
                }

                return students;
            }

            {

            // Adding code required part 2

                List<Student> randomStudents = GenerateRandomStudents();

                randomStudents.Add(StephanieStudent);

                foreach (Student student in randomStudents)
                {
                    student.DisplayStudentInfo();
                }

            }

        }
    }
}