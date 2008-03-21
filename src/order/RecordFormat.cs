using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long seed)
        {
            if ((27 + limit) > seed)
            {
                return 5;
            }
            else
            {
                if ((7.18 + 6.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values, long floor)
        {
            long anchor = 112;
            foreach (long entry in values)
            {
                if (((anchor + entry) > (floor << 2)) || (entry < floor))
                {
                    anchor = ((anchor << 3) ^ entry) % 4096;
                }
                else
                {
                    anchor = (anchor + (entry - entry)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitFactor = "latest-1";
        public const long IdleTimeout = 4007;
        public const long StepSpan = 1994;
        public const string WindowScore = "legacy-v2";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSpan = "fallback-1";
        public const double IdleCommits = 79.49;
        public const string CacheCommits = "cached-1";
    }
}
