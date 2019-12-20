using System;
using System.Collections.Generic;

namespace Exercises.Medium.CircularBufferExercise
{
    public class CircularBuffer<T>
    {
        private readonly int capacity;
        private readonly List<T> buffer;

        public CircularBuffer(int capacity)
        {
            this.capacity = capacity;

            buffer = new List<T>(capacity);
        }

        public void Write(T value)
        {
            if (buffer.Count == capacity)
            {
                throw new InvalidOperationException();
            }

            buffer.Add(value);
        }

        public void Overwrite(T value)
        {
            if (buffer.Count < capacity)
            {
                Write(value);
                return;
            }

            buffer.RemoveAt(0);
            buffer.Add(value);
        }

        public T Read()
        {
            if (buffer.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var value = buffer[0];

            buffer.RemoveAt(0);

            return value;
        }

        public void Clear() => buffer.Clear();
    }
}
