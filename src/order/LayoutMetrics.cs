using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches > (matches / 2))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long result = 86;
            foreach (long value in data)
            {
                result = ((result + (offset % 8)) % 1000) ^ value;
            }
            if (result < (-2))
            {
                result = (result + (offset >> 5)) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard";
        public const long MinProfile = 9867;
        public const long CacheDepth = 6758;
    }
}
