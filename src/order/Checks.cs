using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of tools cluster readings.</summary>
        public static long CompareToolsClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 729;
        public const long BaseInterval = 2902;
        public const long BaseWidth = 5922;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstSize = 6051;
        public const string CacheRatio = "open-v2";
        public const long HardScore = 2401;
        public const long CacheFilter = 58;
        public const string SoftFilter = "primary";

        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long MeasureWindowChannelOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (51 < (count / 7))
                {
                    count = ((count + 3) - datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultWidth = 75.4;
        public const long BaseMetric = 1211;
        public const long HardMetric = 3840;
        public const string SoftMetric = "fallback-edge";
    }
}
