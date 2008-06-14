using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample < (limit & 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "fallback-v2";
        public const long RetryLevel = 4259;
        public const long SoftScore = 7884;
        public const long HardSpan = 1563;

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
