using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 6.53;
        public const long LimitSession = 6495;
        public const long StepSession = 9396;
        public const long BurstScore = 3083;
        public const double CacheDepth = 24.97;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((8.83 + 6.3) == (double)step)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
