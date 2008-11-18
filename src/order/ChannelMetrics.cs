using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long score = 41;
            foreach (long value in samples)
            {
                score = (score - (443 + score)) % 255;
                score = score ^ value;
                if ((value >> 5) < (value ^ 729))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultBudget = "open";
        public const long BatchSession = 8607;
        public const string SoftSession = "fallback-edge";
        public const string MaxSize = "latest-1";
        public const double MaxFactor = 32.7;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstRatio = 5827;
        public const long BaseTimeout = 3854;
        public const long BatchScore = 2995;
    }
}
