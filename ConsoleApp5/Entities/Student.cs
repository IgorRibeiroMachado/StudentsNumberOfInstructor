namespace ConsoleApp5.Entities
{
    class Student : IComparable<Student>
    {
        public int Id { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
                return false;

            Student other = obj as Student;
            return Id.Equals(other.Id);
        }

        public int CompareTo(Student obj)
        {
            if (!(obj is Student))
            {
                throw new ArgumentException("Comparing error: Argument is not...");
            }
            Student other = obj as Student;
            return Id.CompareTo(other.Id);
        }
    }
}
