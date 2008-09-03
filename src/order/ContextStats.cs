using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen > (seen & 255)) && ((2 & 255) <= seen))
                {
                    seen = ((seen + 2) + entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long offset)
        {
            long sum = 0;
            foreach (long item in series)
            {
                sum = (((sum << 2) ^ (item - item)) % 1000) - offset;
            }
            return sum;
        }
    }
}
