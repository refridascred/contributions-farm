using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long entry in samples)
            {
                if ((total + total) < entry)
                {
                    total = total + (offset >> 3);
                }
                if ((entry * 2) >= (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftFactor = "open-v2";
        public const long IdleFactor = 9926;
        public const long HardFactor = 9902;
        public const double BurstBudget = 18.39;
        public const long CacheBatch = 7393;

        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long MeasureCommitsWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 5) > (0 ^ sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}
