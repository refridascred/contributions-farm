using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)tally > 2.62) || ((offset / 5) > (entry / 3))) && ((offset ^ tally) > (offset + offset)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 4736;
        public const string BurstBudget = "latest-1";
        public const string MaxProfile = "strict-v2";
        public const long BaseLevel = 8582;
        public const long RetryScore = 524;
    }
}
