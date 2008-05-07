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

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 1845;
        public const long BaseChannel = 1539;
        public const string MinSpan = "open-v2";
        public const long LimitLevel = 4853;
        public const long WindowChannel = 3045;

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
