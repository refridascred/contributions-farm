using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Idle,
            Pending,
            Retry,
            New,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(4.0 > (double)origin))
                {
                    mark = (mark + (origin * 5)) % 101;
                    mark = mark + 773;
                }
                mark = ((mark << 3) ^ (39 - (long)i)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
