using Exercises.Medium.RotationalCipherExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Medium
{
    public class RotationalCipherTests
    {
        [Test]
        public void Rotate_ByZero_OutputMatchesInput()
        {
            Assert.AreEqual("a", RotationalCipher.Rotate("a", 0));
        }

        [Test]
        public void Rotate_ByOne_OutputIsNextCharacter()
        {
            Assert.AreEqual("b", RotationalCipher.Rotate("a", 1));
        }

        [Test]
        public void Rotate_ByTwentySix_OutputMatchesInput()
        {
            Assert.AreEqual("a", RotationalCipher.Rotate("a", 26));
        }

        [Test]
        public void Rotate_ByThirteen_OutputIsCorrect()
        {
            Assert.AreEqual("z", RotationalCipher.Rotate("m", 13));
        }

        [Test]
        public void Rotate_PastEndOfAlphabet_WrapsAround()
        {
            Assert.AreEqual("a", RotationalCipher.Rotate("n", 13));
        }

        [Test]
        public void Rotate_CapitalLetters_OutputIsCorrect()
        {
            Assert.AreEqual("TRL", RotationalCipher.Rotate("OMG", 5));
        }

        [Test]
        public void Rotate_WithSpaces_OutputIsCorrect()
        {
            Assert.AreEqual("T R L", RotationalCipher.Rotate("O M G", 5));
        }

        [Test]
        public void Rotate_WithNumbers_OutputIsCorrect()
        {
            Assert.AreEqual("Xiwxmrk 1 2 3 xiwxmrk", RotationalCipher.Rotate("Testing 1 2 3 testing", 4));
        }

        [Test]
        public void Rotate_WithPunctuation_OutputIsCorrect()
        {
            Assert.AreEqual("Gzo'n zvo, Bmviyhv!", RotationalCipher.Rotate("Let's eat, Grandma!", 21));
        }

        [Test]
        public void Rotate_WithEveryLetter_OutputIsCorrect()
        {
            Assert.AreEqual("Gur dhvpx oebja sbk whzcf bire gur ynml qbt.", RotationalCipher.Rotate("The quick brown fox jumps over the lazy dog.", 13));
        }
    }
}
