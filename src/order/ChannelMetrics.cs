using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 354;
        public const double BaseSupport = 46.58;
        public const long BatchWidth = 5600;
        public const long IdleScore = 4302;
        public const long BatchDepth = 3537;

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
