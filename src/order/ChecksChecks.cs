using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (5 <= (limit << 2))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= 2.48)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
