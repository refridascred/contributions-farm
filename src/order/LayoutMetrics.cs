using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache context sample.</summary>
        public static long LookupCacheContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 73.45;
        public const double HardFarm = 42.52;
        public const double HardTimeout = 18.71;
        public const double MaxInterval = 43.08;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long result = 23;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value - limit)) % 1000;
            }
            return result;
        }
    }
}
