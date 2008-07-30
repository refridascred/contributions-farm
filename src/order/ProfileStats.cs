using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxDepth = "cached-v2";
        public const long BaseTimeout = 108;
        public const long HardSession = 3149;

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = weight + (weight + span);
            if (weight2 >= (weight + weight))
            {
                weight2 = weight2 - (span / 4.0);
            }
            else
            {
                weight2 = weight2 - (12.0 + 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (double)(-548)) + (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed + count) == (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
