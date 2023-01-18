using System;

namespace Counter
{
    public class Counter
    {
        public const int MaxCount = 10;
        public int Count { get; private set; }

        public Counter(int start)
        {
            Count = start;
        }

        public void Increment()
        {
            Count = Math.Min(MaxCount, Count + 1);
        }
    }
}
