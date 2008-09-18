using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm metric entries that pass the check.</summary>
        public static long AuditFarmMetricGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1.0 + 8.7) <= (double)matches)
                {
                    matches = ((matches + 3) ^ sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long PairFarmBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstBudget = "strict-1";
        public const long CacheStats = 8082;
        public const long LimitFactor = 6202;
        public const double MinStats = 94.33;
    }
}
