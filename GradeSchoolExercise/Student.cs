namespace GradeSchoolExercise
{
    public class Student
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; }
        public int Grade { get; }
    }
}
