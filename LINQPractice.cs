namespace LinqPractice
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student { Id = 1, Name = "Alice", Course = "Math", Grade = 85.5 },
                new Student { Id = 2, Name = "Bob", Course = "Science", Grade = 92.0 },
                new Student { Id = 3, Name = "Charlie", Course = "History", Grade = 78.0 },
                new Student { Id = 4, Name = "Daise", Course = "History", Grade = 91.0 }
            };

            // Find all students with a grade of 90 or above and order them by grade in descending order.
            var topStudents = students.Where(s => s.Grade >= 90).OrderByDescending(s => s.Grade).ToArray();

            // Print the names of the top students along with their courses and grades.
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Course} - {student.Grade}");
            }

            Console.WriteLine("\n");

            // Calculate the average grade of all students and print it to the console.
            var averageGrade = students.Average(s => s.Grade);
            Console.WriteLine($"Average Grade: {(int)averageGrade}");

            Console.WriteLine("\n");

            // Group the students by their course and print the course name along with the names of the students in each course.
            var studentByCourse = students.GroupBy(s => s.Course).ToDictionary(s => s.Key, s => s.ToList());

            // Print the course name along with the names of the students in each course.
            foreach (var course in studentByCourse)
            {
                Console.WriteLine($"Course: {course.Key}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"  {student.Name} - {student.Grade}");
                }
            }

            Console.WriteLine("\n");

            // Order the students by their names in descending order and print their names to the console.
            var studentsByDescending = students.OrderByDescending(s => s.Name).ToList();
            foreach (var student in studentsByDescending)
            {
                Console.WriteLine($"Student: {student.Name}");

            }

        }
    }
}
