using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) > (value & 3)) && (seen > (seen - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits ^ hits) <= (-8))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (4.04 - 9.8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
