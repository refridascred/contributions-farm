using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheInterval = 3.8;
        public const double HardEditor = 7.6;
        public const string RetryEditor = "staging-1";
        public const long BaseEditor = 7629;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate notes stream readings against a bound.</summary>
        public static bool GuardNotesStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Retry,
            Synced,
            Done,
        }
    }
}
