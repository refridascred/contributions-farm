using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5672;
        public const long CacheOrder = 4130;
        public const long LimitOrder = 1854;
        public const long BaseOrder = 9984;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
