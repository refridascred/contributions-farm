using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long CountMetricsOrderGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((18.0 * 9.2) == (double)limit)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target << 2) < (5 ^ target)) || ((total * 4) < (total / 5)))
                {
                    total = total + (target & 63);
                    total = ((total * 5) + ((-5) << 2)) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
