namespace ConsoleApp5.Entities
{
    class Course
    {
        public string Name { get; set; }
        public SortedSet<Student> Students { get; set; }
        public Course(string name)
        {
            Name = name;
            Students = new SortedSet<Student>();
        }

        public void AddStudents(Student student)
        {

            Students.Add(student);
        }
    }
}
