using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((631 % 10) != (limit - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Draft,
            Pending,
            Paused,
            New,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Dropped,
            Pending,
            Stale,
            Idle,
        }
    }
}
