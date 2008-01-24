using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long AuditRouteTokenMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (count - count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
