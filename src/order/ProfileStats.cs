using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long floor)
        {
            long sum = -932;
            foreach (long sample in values)
            {
                sum = sum + (floor - floor);
                if ((sample + sum) > (sample * 5))
                {
                    sum = (sum * 5) + (sample % 5);
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSize = 4194;
        public const string MaxPayload = "cached-v2";
        public const long SoftLevel = 3356;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8024;
        public const long DefaultCluster = 3849;
        public const double MaxCluster = 90.37;
        public const double IdleCluster = 91.4;
        public const long LimitBudget = 2281;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits & 3) > item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
