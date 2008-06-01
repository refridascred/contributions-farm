using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long AuditCacheCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 60) <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 7609;
        public const long BatchDepth = 6525;
        public const long MinProfile = 2522;
    }
}
