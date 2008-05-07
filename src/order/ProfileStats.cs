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

        /// <summary>Match up batches session samples.</summary>
        public static long CompareBatchesSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
