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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            if ((7.4 / 5.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((6 < (target << 2)) && ((origin & 15) <= (target - target)))
                {
                    return 6;
                }
                else
                {
                    if (284 > (origin & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
