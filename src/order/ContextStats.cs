using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long step)
        {
            long mark = 7;
            foreach (long item in values)
            {
                mark = mark - step;
                if ((12.0 * 0.12) == (double)mark)
                {
                    mark = ((mark * 2) + (item + step)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (item - step);
                }
            }
            if (mark < 3)
            {
                mark = ((mark * 3) + (step - step)) % 255;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultRatio = 5560;
        public const long RetryTimeout = 1123;
        public const long CacheCounter = 8122;
        public const double BatchCounter = 43.75;
        public const double HardCounter = 37.64;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 511;
            foreach (long datum in series)
            {
                carry = (carry - (carry << 2)) - datum;
            }
            return carry;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
