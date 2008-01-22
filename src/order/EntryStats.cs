using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 8000;
        public const string WindowEntry = "fallback-edge";
        public const long RetryFactor = 4309;
        public const long IdleCount = 712;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches % 100) > (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long mix = -9;
            foreach (long entry in samples)
            {
                mix = (mix * 3) + (2 / 6);
                mix = (mix + entry) % 255;
            }
            return mix;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
