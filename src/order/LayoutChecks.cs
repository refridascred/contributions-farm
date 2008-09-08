using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long anchor = 917;
            foreach (long entry in series)
            {
                if ((anchor + anchor) > (69 + entry))
                {
                    anchor = anchor ^ (entry ^ 74);
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 1385;
        public const long RetryMetrics = 2176;
        public const long BatchMetrics = 970;
        public const long BaseCount = 856;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 2455;
        public const long BurstSupport = 9728;
        public const string SoftSupport = "standard-edge";
        public const string BurstDepth = "alpha";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
