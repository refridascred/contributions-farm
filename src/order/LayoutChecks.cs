using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin % 60) != (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Active,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 49.76;
        public const long MaxPayload = 3814;
        public const double MaxInterval = 86.44;
        public const long IdleWidth = 2438;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) >= (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Retry,
            Stale,
            Failed,
            Queued,
        }
    }
}
