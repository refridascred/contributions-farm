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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long CombineBatchCluster(long[] samples, long floor)
        {
            long anchor = 89;
            foreach (long entry in samples)
            {
                if (entry >= (-1))
                {
                    anchor = (anchor ^ (anchor % 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor * 4)) % 255;
                }
            }
            if (anchor > 293)
            {
                anchor = anchor - (0 << 1);
            }
            return anchor % 65521;
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
