using ClockExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Medium
{
    public class ClockTests
    {
        [Test]
        public void On_the_hour()
        {
            var clock = new Clock(8, 0);
            Assert.AreEqual("08:00", clock.ToString());
        }

        [Test]
        public void Past_the_hour()
        {
            var clock = new Clock(11, 9);
            Assert.AreEqual("11:09", clock.ToString());
        }

        [Test]
        public void Midnight_is_zero_hours()
        {
            var clock = new Clock(24, 0);
            Assert.AreEqual("00:00", clock.ToString());
        }

        [Test]
        public void Hour_rolls_over()
        {
            var clock = new Clock(25, 0);
            Assert.AreEqual("01:00", clock.ToString());
        }

        [Test]
        public void Hour_rolls_over_continuously()
        {
            var clock = new Clock(100, 0);
            Assert.AreEqual("04:00", clock.ToString());
        }

        [Test]
        public void Sixty_minutes_is_next_hour()
        {
            var clock = new Clock(1, 60);
            Assert.AreEqual("02:00", clock.ToString());
        }

        [Test]
        public void Minutes_roll_over()
        {
            var clock = new Clock(0, 160);
            Assert.AreEqual("02:40", clock.ToString());
        }

        [Test]
        public void Minutes_roll_over_continuously()
        {
            var clock = new Clock(0, 1723);
            Assert.AreEqual("04:43", clock.ToString());
        }

        [Test]
        public void Hour_and_minutes_roll_over()
        {
            var clock = new Clock(25, 160);
            Assert.AreEqual("03:40", clock.ToString());
        }

        [Test]
        public void Hour_and_minutes_roll_over_continuously()
        {
            var clock = new Clock(201, 3001);
            Assert.AreEqual("11:01", clock.ToString());
        }

        [Test]
        public void Hour_and_minutes_roll_over_to_exactly_midnight()
        {
            var clock = new Clock(72, 8640);
            Assert.AreEqual("00:00", clock.ToString());
        }

        [Test]
        public void Negative_hour()
        {
            var clock = new Clock(-1, 15);
            Assert.AreEqual("23:15", clock.ToString());
        }

        [Test]
        public void Negative_hour_rolls_over()
        {
            var clock = new Clock(-25, 0);
            Assert.AreEqual("23:00", clock.ToString());
        }

        [Test]
        public void Negative_hour_rolls_over_continuously()
        {
            var clock = new Clock(-91, 0);
            Assert.AreEqual("05:00", clock.ToString());
        }

        [Test]
        public void Negative_minutes()
        {
            var clock = new Clock(1, -40);
            Assert.AreEqual("00:20", clock.ToString());
        }

        [Test]
        public void Negative_minutes_roll_over()
        {
            var clock = new Clock(1, -160);
            Assert.AreEqual("22:20", clock.ToString());
        }

        [Test]
        public void Negative_minutes_roll_over_continuously()
        {
            var clock = new Clock(1, -4820);
            Assert.AreEqual("16:40", clock.ToString());
        }

        [Test]
        public void Negative_hour_and_minutes_both_roll_over()
        {
            var clock = new Clock(-25, -160);
            Assert.AreEqual("20:20", clock.ToString());
        }

        [Test]
        public void Negative_hour_and_minutes_both_roll_over_continuously()
        {
            var clock = new Clock(-121, -5810);
            Assert.AreEqual("22:10", clock.ToString());
        }

        [Test]
        public void Add_minutes()
        {
            var clock = new Clock(10, 0);
            Assert.AreEqual("10:03", clock.Add(3).ToString());
        }

        [Test]
        public void Add_no_minutes()
        {
            var clock = new Clock(6, 41);
            Assert.AreEqual("06:41", clock.Add(0).ToString());
        }

        [Test]
        public void Add_to_next_hour()
        {
            var clock = new Clock(0, 45);
            Assert.AreEqual("01:25", clock.Add(40).ToString());
        }

        [Test]
        public void Add_more_than_one_hour()
        {
            var clock = new Clock(10, 0);
            Assert.AreEqual("11:01", clock.Add(61).ToString());
        }

        [Test]
        public void Add_more_than_two_hours_with_carry()
        {
            var clock = new Clock(0, 45);
            Assert.AreEqual("03:25", clock.Add(160).ToString());
        }

        [Test]
        public void Add_across_midnight()
        {
            var clock = new Clock(23, 59);
            Assert.AreEqual("00:01", clock.Add(2).ToString());
        }

        [Test]
        public void Add_more_than_one_day_1500_min_25_hrs_()
        {
            var clock = new Clock(5, 32);
            Assert.AreEqual("06:32", clock.Add(1500).ToString());
        }

        [Test]
        public void Add_more_than_two_days()
        {
            var clock = new Clock(1, 1);
            Assert.AreEqual("11:21", clock.Add(3500).ToString());
        }

        [Test]
        public void Subtract_minutes()
        {
            var clock = new Clock(10, 3);
            Assert.AreEqual("10:00", clock.Subtract(3).ToString());
        }

        [Test]
        public void Subtract_to_previous_hour()
        {
            var clock = new Clock(10, 3);
            Assert.AreEqual("09:33", clock.Subtract(30).ToString());
        }

        [Test]
        public void Subtract_more_than_an_hour()
        {
            var clock = new Clock(10, 3);
            Assert.AreEqual("08:53", clock.Subtract(70).ToString());
        }

        [Test]
        public void Subtract_across_midnight()
        {
            var clock = new Clock(0, 3);
            Assert.AreEqual("23:59", clock.Subtract(4).ToString());
        }

        [Test]
        public void Subtract_more_than_two_hours()
        {
            var clock = new Clock(0, 0);
            Assert.AreEqual("21:20", clock.Subtract(160).ToString());
        }

        [Test]
        public void Subtract_more_than_two_hours_with_borrow()
        {
            var clock = new Clock(6, 15);
            Assert.AreEqual("03:35", clock.Subtract(160).ToString());
        }

        [Test]
        public void Subtract_more_than_one_day_1500_min_25_hrs_()
        {
            var clock = new Clock(5, 32);
            Assert.AreEqual("04:32", clock.Subtract(1500).ToString());
        }

        [Test]
        public void Subtract_more_than_two_days()
        {
            var clock = new Clock(2, 20);
            Assert.AreEqual("00:20", clock.Subtract(3000).ToString());
        }

        [Test]
        public void Clocks_with_same_time()
        {
            var clock = new Clock(15, 37);
            Assert.AreEqual(new Clock(15, 37), clock);
        }

        [Test]
        public void Clocks_a_minute_apart()
        {
            var clock = new Clock(15, 37);
            Assert.AreNotEqual(new Clock(15, 36), clock);
        }

        [Test]
        public void Clocks_an_hour_apart()
        {
            var clock = new Clock(15, 37);
            Assert.AreNotEqual(new Clock(14, 37), clock);
        }

        [Test]
        public void Clocks_with_hour_overflow()
        {
            var clock = new Clock(34, 37);
            Assert.AreEqual(new Clock(10, 37), clock);
        }

        [Test]
        public void Clocks_with_hour_overflow_by_several_days()
        {
            var clock = new Clock(99, 11);
            Assert.AreEqual(new Clock(3, 11), clock);
        }

        [Test]
        public void Clocks_with_negative_hour()
        {
            var clock = new Clock(-2, 40);
            Assert.AreEqual(new Clock(22, 40), clock);
        }

        [Test]
        public void Clocks_with_negative_hour_that_wraps()
        {
            var clock = new Clock(-31, 3);
            Assert.AreEqual(new Clock(17, 3), clock);
        }

        [Test]
        public void Clocks_with_negative_hour_that_wraps_multiple_times()
        {
            var clock = new Clock(-83, 49);
            Assert.AreEqual(new Clock(13, 49), clock);
        }

        [Test]
        public void Clocks_with_minute_overflow()
        {
            var clock = new Clock(0, 1441);
            Assert.AreEqual(new Clock(0, 1), clock);
        }

        [Test]
        public void Clocks_with_minute_overflow_by_several_days()
        {
            var clock = new Clock(2, 4322);
            Assert.AreEqual(new Clock(2, 2), clock);
        }

        [Test]
        public void Clocks_with_negative_minute()
        {
            var clock = new Clock(3, -20);
            Assert.AreEqual(new Clock(2, 40), clock);
        }

        [Test]
        public void Clocks_with_negative_minute_that_wraps()
        {
            var clock = new Clock(5, -1490);
            Assert.AreEqual(new Clock(4, 10), clock);
        }

        [Test]
        public void Clocks_with_negative_minute_that_wraps_multiple_times()
        {
            var clock = new Clock(6, -4305);
            Assert.AreEqual(new Clock(6, 15), clock);
        }

        [Test]
        public void Clocks_with_negative_hours_and_minutes()
        {
            var clock = new Clock(-12, -268);
            Assert.AreEqual(new Clock(7, 32), clock);
        }

        [Test]
        public void Clocks_with_negative_hours_and_minutes_that_wrap()
        {
            var clock = new Clock(-54, -11513);
            Assert.AreEqual(new Clock(18, 7), clock);
        }
    }
}
