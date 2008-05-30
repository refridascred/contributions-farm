using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = scale;
            if (bias <= 9.3)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias / 8.0)) + (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 2682;
        public const string MaxCommits = "legacy-v2";
        public const long BurstCommits = 1724;
        public const long DefaultWidth = 9807;
        public const long CacheCommits = 8423;
    }
}
