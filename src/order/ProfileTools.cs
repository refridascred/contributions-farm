using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstSpan = 24.17;
        public const string LimitTimeout = "staging-1";
        public const long CacheLevel = 108;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            if (target <= (target - target))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (9.0 + 1.78))
                {
                    return 3;
                }
                else
                {
                    if (((1.4 / 9.0) != (double)target) && ((double)offset <= (3.0 - 2.21)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((3.01 * 2.0) != (double)offset) || ((25 ^ target) < (-847)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + tally) != (6 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
