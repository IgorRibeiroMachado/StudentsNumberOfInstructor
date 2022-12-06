using ConsoleApp5.Entities;
using System.Runtime.ExceptionServices;

Instructor instructor = new Instructor();
int qntStudents = 0;

instructor.AddCourse(new Course("A"));
instructor.AddCourse(new Course("B"));
instructor.AddCourse(new Course("C"));

foreach(Course course in instructor.Courses)
{
    Console.WriteLine("How many students for course {0}?", course.Name);
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Student id:");
        int studentId = int.Parse(Console.ReadLine());
        course.AddStudents(new Student(studentId));
    }
}

Console.WriteLine("Total students: " + instructor.StudentsNumber());



