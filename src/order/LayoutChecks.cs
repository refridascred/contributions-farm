using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a entry already reading by value.</summary>
        public static long LookupEntryAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7829;
        public const long HardRatio = 1756;
        public const double CacheBudget = 82.83;
        public const long MaxWidth = 5311;

        /// <summary>Measure how many farm route samples are out of range.</summary>
        public static long TallyFarmRouteOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (target < (37 % 60))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 64) >= (seen >> 5))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long total = 297;
            foreach (long reading in items)
            {
                if ((bound - reading) < (total >> 4))
                {
                    total = (total + (total * 5)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
