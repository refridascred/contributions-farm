using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command metrics samples are out of range.</summary>
        public static long AuditCommandMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + matches) < (matches + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long MeasureEntryMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (13.0 * 5.8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
