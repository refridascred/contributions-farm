using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (hits + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)origin)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Idle,
            Synced,
            Stale,
        }
    }
}
