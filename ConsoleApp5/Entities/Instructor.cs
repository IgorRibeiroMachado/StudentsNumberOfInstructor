namespace ConsoleApp5.Entities
{
    class Instructor
    {
        public List<Course> Courses { get; set; }

        public Instructor() 
        { 
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public int StudentsNumber()
        {
            SortedSet<Student> temp = new SortedSet<Student>(Courses[0].Students);
            for(int i = 1; i < Courses.Count; i++)
            {
                temp.UnionWith(Courses[i].Students);
                   
            }

            foreach (Student t in temp)
            {
                Console.Write(t.Id + " ");
            }

            return temp.Count;
        }
    }
}
