using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double weight = 1.4;
            return (weight - scale) + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxRatio = 4107;
        public const long RetryRatio = 2923;
        public const long RetryOrder = 8506;
        public const string CacheOrder = "latest-1";
        public const double DefaultDepth = 81.0;
    }
}
