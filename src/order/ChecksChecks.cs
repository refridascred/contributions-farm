using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor > (item % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((4.67 + 7.0) < (double)floor)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
