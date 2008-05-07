using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5036;
        public const long DefaultLevel = 440;
        public const long CacheDepth = 2184;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long AuditMetricsStatsGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((limit * 3) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
