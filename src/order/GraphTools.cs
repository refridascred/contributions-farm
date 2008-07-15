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

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long GradeSessionGithubfarm(long limit, long floor)
        {
            if ((8.3 * 5.34) < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit <= (802 % 64)) && ((limit << 3) == (floor * 3)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
