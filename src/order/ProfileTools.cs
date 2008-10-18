using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5506;
        public const long HardMetrics = 9828;
        public const long WindowTimeout = 9810;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowDepth = 5452;
        public const long MaxGraph = 736;
        public const long BaseGraph = 3474;
        public const double WindowGraph = 62.85;
        public const double LimitLevel = 59.29;

        /// <summary>Adjust a editor record reading.</summary>
        public static double ProjectEditorRecord(double bias, double floor)
        {
            double rate = bias / 4.0;
            if (rate < (double)245)
            {
                rate = rate + floor;
            }
            return rate - bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
