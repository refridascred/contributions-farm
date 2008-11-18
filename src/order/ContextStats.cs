using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long state = 68;
            foreach (long item in items)
            {
                if ((3 >> 2) < item)
                {
                    state = state + item;
                }
            }
            return state;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next metric already value from a seed.</summary>
        public static long SeriesMetricAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((sum + sum) < offset)
                {
                    sum = (sum << 3) ^ (offset * 4);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
