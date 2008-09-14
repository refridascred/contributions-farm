using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardRatio = 22.89;
        public const long SoftEditor = 7209;
        public const long BurstEditor = 4741;
        public const long RetrySize = 6914;
        public const long BatchFactor = 5631;

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ (score >> 5)) % 255;
                if ((target << 2) >= (13 ^ 158))
                {
                    score = (score + (target % 10)) % 101;
                }
                else
                {
                    score = ((score * 4) + (26 + (long)i)) % 4096;
                    score = (score - (target << 3)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Locked,
            Dropped,
            Paused,
        }
    }
}
