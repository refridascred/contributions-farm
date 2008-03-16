using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Dropped,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long limit)
        {
            long acc = 41;
            foreach (long value in items)
            {
                acc = (((acc + acc) % 4096) + value) + limit;
            }
            return acc;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Retry,
            Idle,
            Done,
        }
    }
}
