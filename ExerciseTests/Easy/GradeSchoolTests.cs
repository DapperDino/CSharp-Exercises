using Exercises.Easy.GradeSchoolExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Easy
{
    public class GradeSchoolTests
    {
        [Test]
        public void AddStudent_SingleStudent_StudentIsAddedToRoster()
        {
            var school = new School();
            var aimee = new Student("Aimee", 2);

            school.AddStudent(aimee);
            var actual = school.GetAllStudents();

            var expected = new[] { aimee };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddStudent_MultipleStudents_StudentsAreAddedToRosterInOrder()
        {
            var school = new School();
            var blair = new Student("Blair", 2);
            var james = new Student("James", 2);
            var paul = new Student("Paul", 2);

            school.AddStudent(blair);
            school.AddStudent(james);
            school.AddStudent(paul);
            var actual = school.GetAllStudents();

            var expected = new[] { blair, james, paul };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Roster_TwoStudentsInDifferentGrades_StudentsAreAddedToRosterInOrder()
        {
            var school = new School();
            var chelsea = new Student("Chelsea", 3);
            var logan = new Student("Logan", 7);

            school.AddStudent(chelsea);
            school.AddStudent(logan);
            var actual = school.GetAllStudents();

            var expected = new[] { chelsea, logan };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetStudentsByGrade_GetsStudentsInGradeInAlphabeticalOrder()
        {
            var school = new School();
            var franklin = new Student("Franklin", 5);
            var bradley = new Student("Bradley", 5);
            var jeff = new Student("Jeff", 1);

            school.AddStudent(franklin);
            school.AddStudent(bradley);
            school.AddStudent(jeff);
            var actual = school.GetStudentsByGrade(5);

            var expected = new[] { bradley, franklin };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetStudentsByGrade_NoStudentsInGrade_IsAnEmptyArray()
        {
            var school = new School();

            var actual = school.GetStudentsByGrade(1);

            Assert.IsEmpty(actual);
        }

        [Test]
        public void Roster_ManyStudentsInDifferentGrades_StudentsAreAddedToRosterInOrder()
        {
            var school = new School();
            var peter = new Student("Peter", 2);
            var anna = new Student("Anna", 1);
            var barb = new Student("Barb", 1);
            var zoe = new Student("Zoe", 2);
            var alex = new Student("Alex", 2);
            var jim = new Student("Jim", 3);
            var charlie = new Student("Charlie", 1);


            school.AddStudent(peter);
            school.AddStudent(anna);
            school.AddStudent(barb);
            school.AddStudent(zoe);
            school.AddStudent(alex);
            school.AddStudent(jim);
            school.AddStudent(charlie);
            var actual = school.GetAllStudents();

            var expected = new[] { anna, barb, charlie, alex, peter, zoe, jim };
            Assert.AreEqual(expected, actual);
        }
    }
}
