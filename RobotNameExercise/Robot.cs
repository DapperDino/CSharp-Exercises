using System;
using System.Collections.Generic;

namespace RobotNameExercise
{
    public class Robot
    {
        private static readonly Random Random = new Random();

        private static readonly HashSet<string> ExistingRobotNames = new HashSet<string>();

        public string Name { get; private set; }

        public Robot() => Reset();

        public void Reset() => Name = GetUniqueName();

        private static string GetUniqueName()
        {
            string robotName = GenerateRobotName();

            while (!ExistingRobotNames.Add(robotName))
            {
                robotName = GenerateRobotName();
            }

            return robotName;
        }

        private static string GenerateRobotName()
        {
            var newName = new char[5];

            for (int i = 0; i < 2; i++)
            {
                newName[i] = (char)Random.Next('A', 'Z' + 1);
            }

            for (int i = 2; i < 5; i++)
            {
                newName[i] = (char)Random.Next('0', '9' + 1);
            }

            return new string(newName);
        }
    }
}
