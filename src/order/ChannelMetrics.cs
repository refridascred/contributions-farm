using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 2532;
        public const long RetryGraph = 2758;
        public const long MinGraph = 9282;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((floor % 24) < hits) || (((double)floor > (5.6 + 5.2)) && ((8.0 + 8.3) > (double)sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2464;
        public const long MinOrder = 3326;
        public const long DefaultBudget = 6335;
        public const double DefaultOrder = 29.45;
    }
}
