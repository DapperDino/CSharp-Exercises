using HelloWorldExercise;
using NUnit.Framework;

namespace ExerciseTests.Tests.Easy
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
