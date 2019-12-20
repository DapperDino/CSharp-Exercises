using Exercises.Easy.HelloWorldExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Easy
{
    public class HelloWorldTests
    {
        [Test]
        public void HelloWorld_IsCorrectString()
        {
            Assert.AreEqual("Hello, World!", HelloWorld.Hello());
        }
    }
}
