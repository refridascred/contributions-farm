using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items, long target)
        {
            long anchor = 150;
            foreach (long sample in items)
            {
                anchor = ((((anchor * 3) + (anchor + (-34))) % 1000) + sample) + target;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 19.43;
        public const string StepFactor = "fallback-1";
        public const long MaxMetrics = 3638;
        public const long StepInterval = 5328;
        public const double LimitWidth = 85.38;
    }
}
