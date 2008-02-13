using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry - count) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 44.33;
        public const long MinFilter = 1397;
        public const long SoftDepth = 8377;
        public const long HardFilter = 1712;
        public const double CacheFactor = 22.91;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long step)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (((state + state) % 97) - item) - step;
            }
            return state % 65521;
        }

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long IterateSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
