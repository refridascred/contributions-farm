using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((4.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Find the first token tools entry that matches the target.</summary>
        public static long FindTokenToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((4.57 - 2.69) < (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
