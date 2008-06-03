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

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double rate2 = rate * 4.3;
            if (rate2 < rate2)
            {
                rate2 = rate2 - (span + 2.87);
            }
            else
            {
                rate2 = rate2 - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (double)43) + (double)(long)i;
            }
            return rate2 - span;
        }
    }
}
