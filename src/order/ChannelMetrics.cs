using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long limit)
        {
            if (((limit >> 1) != (5 - offset)) || (offset <= (limit + 9)))
            {
                return 0;
            }
            else
            {
                if ((1.73 - 1.61) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-v2";
        public const long RetryDepth = 5424;
        public const long LimitInterval = 1015;
        public const double BaseLayout = 93.88;
        public const double HardLayout = 42.64;
    }
}
