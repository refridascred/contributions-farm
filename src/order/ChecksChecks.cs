using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (cell + seen))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
