using BobExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Medium
{
    public class Bobtests
    {
        [Test]
        public void Stating_something()
        {
            Assert.AreEqual("Whatever.", Bob.Response("Tom-ay-to, tom-aaaah-to."));
        }

        [Test]
        public void Shouting()
        {
            Assert.AreEqual("Whoa, chill out!", Bob.Response("WATCH OUT!"));
        }

        [Test]
        public void Shouting_gibberish()
        {
            Assert.AreEqual("Whoa, chill out!", Bob.Response("FCECDFCAAB"));
        }

        [Test]
        public void Asking_a_question()
        {
            Assert.AreEqual("Sure.", Bob.Response("Does this cryogenic chamber make me look fat?"));
        }

        [Test]
        public void Asking_a_numeric_question()
        {
            Assert.AreEqual("Sure.", Bob.Response("You are, what, like 15?"));
        }

        [Test]
        public void Asking_gibberish()
        {
            Assert.AreEqual("Sure.", Bob.Response("fffbbcbeab?"));
        }

        [Test]
        public void Talking_forcefully()
        {
            Assert.AreEqual("Whatever.", Bob.Response("Let's go make out behind the gym!"));
        }

        [Test]
        public void Using_acronyms_in_regular_speech()
        {
            Assert.AreEqual("Whatever.", Bob.Response("It's OK if you don't want to go to the DMV."));
        }

        [Test]
        public void Forceful_question()
        {
            Assert.AreEqual("Calm down, I know what I'm doing!", Bob.Response("WHAT THE HELL WERE YOU THINKING?"));
        }

        [Test]
        public void Shouting_numbers()
        {
            Assert.AreEqual("Whoa, chill out!", Bob.Response("1, 2, 3 GO!"));
        }

        [Test]
        public void No_letters()
        {
            Assert.AreEqual("Whatever.", Bob.Response("1, 2, 3"));
        }

        [Test]
        public void Question_with_no_letters()
        {
            Assert.AreEqual("Sure.", Bob.Response("4?"));
        }

        [Test]
        public void Shouting_with_special_characters()
        {
            Assert.AreEqual("Whoa, chill out!", Bob.Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));
        }

        [Test]
        public void Shouting_with_no_exclamation_mark()
        {
            Assert.AreEqual("Whoa, chill out!", Bob.Response("I HATE THE DMV"));
        }

        [Test]
        public void Statement_containing_question_mark()
        {
            Assert.AreEqual("Whatever.", Bob.Response("Ending with ? means a question."));
        }

        [Test]
        public void Non_letters_with_question()
        {
            Assert.AreEqual("Sure.", Bob.Response(":) ?"));
        }

        [Test]
        public void Prattling_on()
        {
            Assert.AreEqual("Sure.", Bob.Response("Wait! Hang on. Are you going to be OK?"));
        }

        [Test]
        public void Silence()
        {
            Assert.AreEqual("Fine. Be that way!", Bob.Response(""));
        }

        [Test]
        public void Prolonged_silence()
        {
            Assert.AreEqual("Fine. Be that way!", Bob.Response("          "));
        }

        [Test]
        public void Alternate_silence()
        {
            Assert.AreEqual("Fine. Be that way!", Bob.Response("\t\t\t\t\t\t\t\t\t\t"));
        }

        [Test]
        public void Multiple_line_question()
        {
            Assert.AreEqual("Whatever.", Bob.Response("\nDoes this cryogenic chamber make me look fat?\nNo."));
        }

        [Test]
        public void Starting_with_whitespace()
        {
            Assert.AreEqual("Whatever.", Bob.Response("         hmmmmmmm..."));
        }

        [Test]
        public void Ending_with_whitespace()
        {
            Assert.AreEqual("Sure.", Bob.Response("Okay if like my  spacebar  quite a bit?   "));
        }

        [Test]
        public void Other_whitespace()
        {
            Assert.AreEqual("Fine. Be that way!", Bob.Response("\n\r \t"));
        }

        [Test]
        public void Non_question_ending_with_whitespace()
        {
            Assert.AreEqual("Whatever.", Bob.Response("This is a statement ending with whitespace      "));
        }
    }
}
