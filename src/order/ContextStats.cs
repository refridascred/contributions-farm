using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stats report sample.</summary>
        public static long LocateStatsReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor format readings against a rule.</summary>
        public static long AuditEditorFormatGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + seen) == (12 - seen))
                {
                    seen = ((seen + 2) ^ sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) < (hits + sample))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
