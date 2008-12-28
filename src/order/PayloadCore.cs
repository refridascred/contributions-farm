using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "open";
        public const double BurstLevel = 55.72;
        public const long CacheTimeout = 5559;
        public const double CacheStream = 35.01;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((3 * 2) >= hits)
                {
                    hits = ((hits + 2) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
