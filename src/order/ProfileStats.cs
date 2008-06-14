using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
