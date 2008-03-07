using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + hits) > (9 - hits))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((10.0 * 15.0) == (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
