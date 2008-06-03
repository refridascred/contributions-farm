using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheInterval = "open-v2";
        public const long RetryCount = 5504;
        public const long LimitLevel = 6833;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Idle,
            Synced,
            New,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 8054;
        public const long BurstWidth = 120;
        public const long SoftFactor = 9669;
        public const long MinStream = 6692;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long result = 43;
            foreach (long value in samples)
            {
                result = ((result ^ (result - result)) + value) - limit;
            }
            if (result > 696)
            {
                result = (result * 4) + (118 * 2);
            }
            return result;
        }
    }
}
