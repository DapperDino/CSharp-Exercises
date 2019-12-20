using Exercises.Medium.CircularBufferExercise;
using NUnit.Framework;
using System;

namespace Exercises.ExerciseTests.Medium
{
    public class CircularBufferTests
    {
        [Test]
        public void Read_EmptyBuffer_ThrowsException()
        {
            var buffer = new CircularBuffer<int>(1);

            Assert.Throws<InvalidOperationException>(() => buffer.Read());
        }

        [Test]
        public void Read_ItemJustWritten_IsRead()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);

            Assert.AreEqual(1, buffer.Read());
        }

        [Test]
        public void Read_ItemHasBeenRead_ThowsException()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);

            Assert.AreEqual(1, buffer.Read());
            Assert.Throws<InvalidOperationException>(() => buffer.Read());
        }

        [Test]
        public void Read_ItemsAreReadInOrderOfBeingAdded()
        {
            var buffer = new CircularBuffer<int>(2);

            buffer.Write(1);
            buffer.Write(2);

            Assert.AreEqual(1, buffer.Read());
            Assert.AreEqual(2, buffer.Read());
        }

        [Test]
        public void Write_FullBuffer_ThrowsException()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);

            Assert.Throws<InvalidOperationException>(() => buffer.Write(2));
        }

        [Test]
        public void Read_FullBuffer_CreatesRoomToBeWrittenTo()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);
            Assert.AreEqual(1, buffer.Read());

            buffer.Write(2);
            Assert.AreEqual(2, buffer.Read());
        }

        [Test]
        public void Read_OverMultipleWrites_ReadPositionIsMaintained()
        {
            var buffer = new CircularBuffer<int>(3);

            buffer.Write(1);
            buffer.Write(2);

            Assert.AreEqual(1, buffer.Read());

            buffer.Write(3);

            Assert.AreEqual(2, buffer.Read());
            Assert.AreEqual(3, buffer.Read());
        }

        [Test]
        public void Clear_ItemsClearedCanNotBeRead()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);
            buffer.Clear();

            Assert.Throws<InvalidOperationException>(() => buffer.Read());
        }

        [Test]
        public void Clear_FullBuffer_CanNowBeWrittenTo()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Write(1);
            buffer.Clear();
            buffer.Write(2);

            Assert.AreEqual(2, buffer.Read());
        }

        [Test]
        public void Clear_EmptyBuffer_DoesNothing()
        {
            var buffer = new CircularBuffer<int>(1);

            buffer.Clear();
            buffer.Write(1);

            Assert.AreEqual(1, buffer.Read());
        }

        [Test]
        public void Overwrite_NonFullBuffer_ActsLikeWrite()
        {
            var buffer = new CircularBuffer<int>(2);

            buffer.Write(1);
            buffer.Overwrite(2);

            Assert.AreEqual(1, buffer.Read());
            Assert.AreEqual(2, buffer.Read());
        }

        [Test]
        public void Overwrite_FullBuffer_ReplacesOldestItem()
        {
            var buffer = new CircularBuffer<int>(2);

            buffer.Write(1);
            buffer.Write(2);
            buffer.Overwrite(3);

            Assert.AreEqual(2, buffer.Read());
            Assert.AreEqual(3, buffer.Read());
        }

        [Test]
        public void Overwrite_AfterAReadOnAFullBufferAndAWrite_ReplacesOldestItem()
        {
            var buffer = new CircularBuffer<int>(3);

            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);

            Assert.AreEqual(1, buffer.Read());

            buffer.Write(4);
            buffer.Overwrite(5);

            Assert.AreEqual(3, buffer.Read());
            Assert.AreEqual(4, buffer.Read());
            Assert.AreEqual(5, buffer.Read());
        }
    }
}
