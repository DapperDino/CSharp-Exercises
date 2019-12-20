using Exercises.Easy.RobotNameExercise;
using NUnit.Framework;
using System.Collections.Generic;

namespace Exercises.ExerciseTests.Easy
{
    public class RobotNameTests
    {
        [Test]
        public void Name_IsAValidName()
        {
            var robot = new Robot();

            StringAssert.IsMatch(@"^[A-Z]{2}\d{3}$", robot.Name);
        }

        [Test]
        public void Name_SameRobot_IsTheSameAfterEachCheck()
        {
            var robot = new Robot();

            Assert.AreEqual(robot.Name, robot.Name);
        }

        [Test]
        public void Name_DifferentRobots_NamesAreDifferent()
        {
            var robotOne = new Robot();
            var robotTwo = new Robot();

            Assert.AreNotEqual(robotOne.Name, robotTwo.Name);
        }
        
        [Test]
        public void Reset_NewNameIsDifferentToPreviousName()
        {
            var robot = new Robot();
            string originalName = robot.Name;

            robot.Reset();

            Assert.AreNotEqual(originalName, robot.Name);
        }

        [Test]
        public void Reset_NewNameIsStillValid()
        {
            var robot = new Robot();

            robot.Reset();

            StringAssert.IsMatch(@"^[A-Z]{2}\d{3}$", robot.Name);
        }

        [Test]
        public void Robot_NamesAreUnique()
        {
            var names = new HashSet<string>();
            for (int i = 0; i < 10000; i++)
            {
                var robot = new Robot();
                Assert.True(names.Add(robot.Name));
            }
        }
    }
}
