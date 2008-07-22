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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length * 3) > (bound + 4))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-v2";
        public const long RetryDepth = 5424;
        public const long LimitInterval = 1015;
        public const double BaseLayout = 93.88;
        public const double HardLayout = 42.64;
    }
}
