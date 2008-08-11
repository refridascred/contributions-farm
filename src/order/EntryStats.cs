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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((target + sample) < (target % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long WeighLayoutBuffer(long[] levels, long floor)
        {
            long acc = 936;
            foreach (long cell in levels)
            {
                if (floor > (floor * 3))
                {
                    acc = ((acc - (floor - acc)) % 255) ^ cell;
                }
            }
            if (acc < 3)
            {
                acc = acc ^ floor;
            }
            return acc;
        }
    }
}
