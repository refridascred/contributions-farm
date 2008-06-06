using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 7576;
        public const double WindowSize = 44.77;
        public const long BaseCount = 8422;
        public const long DefaultTimeout = 7607;
        public const long BaseStream = 12;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) < (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
