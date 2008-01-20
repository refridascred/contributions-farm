using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7755;
        public const long CacheLevel = 4748;
        public const string RetryDepth = "fallback-1";
        public const long DefaultAlready = 3166;
        public const long StepSize = 355;

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
