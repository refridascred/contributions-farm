using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((6 - target) > 9)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)66 == (double)cell) || ((cell - tally) != (tally + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph format readings.</summary>
        public static long WeighGraphFormat(long[] levels, long seed)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                mark = (mark << 3) ^ (item ^ seed);
            }
            return mark % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Done,
            Retry,
            Stale,
        }
    }
}
