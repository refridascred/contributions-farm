using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3164;
        public const double MaxCount = 9.4;
        public const long LimitScore = 8147;
        public const long MaxTimeout = 2177;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                long diff = carry + carry;
                if ((origin % 64) < (diff - diff))
                {
                    carry = carry - ((long)i + origin);
                }
                else
                {
                    carry = (carry - origin) % 255;
                }
                carry = (carry - (long)i) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (150 >= ((long)levels.Length - count))
                {
                    count = ((count + 2) ^ reading) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            New,
            Locked,
            Queued,
        }
    }
}
