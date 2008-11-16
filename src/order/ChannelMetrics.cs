using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5775;
        public const long IdleChecks = 7767;
        public const double CacheRatio = 8.92;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) <= (sample >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
