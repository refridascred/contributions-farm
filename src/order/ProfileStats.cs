using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 9287;
        public const long BatchInterval = 4486;
        public const long IdleFactor = 5129;
        public const string CacheDepth = "fallback";

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long score = -62;
            foreach (long item in values)
            {
                if ((item - 869) >= (4 & 31))
                {
                    score = (score + (seed + score)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
