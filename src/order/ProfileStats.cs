using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double ProjectCommandRecord(double bias, double offset)
        {
            double scale = offset + offset;
            return (scale + scale) + bias;
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
