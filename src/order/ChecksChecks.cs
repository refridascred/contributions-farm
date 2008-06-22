using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of support stats readings.</summary>
        public static long CompareSupportStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
