using System.Collections.Generic;
using System.Linq;

namespace GradeSchoolExercise
{
    public class School
    {
        private readonly List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students
                .OrderBy(x => x.Grade)
                .ThenBy(x => x.Name)
                .ToList();
        }

        public List<Student> GetStudentsByGrade(int grade)
        {
            return GetAllStudents()
                .Where(x => x.Grade == grade)
                .ToList();
        }
    }
}
