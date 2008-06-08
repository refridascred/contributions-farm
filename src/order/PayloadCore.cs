using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 2802;
        public const long DefaultRoute = 3287;
        public const long MaxRoute = 4381;
        public const double IdleSpan = 29.5;
        public const long MaxSize = 8940;

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (11.0 * 4.3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleBudget = 26.48;
        public const long WindowInterval = 4365;
        public const long BurstSupport = 8892;
        public const string CacheSupport = "local";
    }
}
