using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats cluster readings against a rule.</summary>
        public static long TallyStatsClusterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (target >= (target - target))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double rate = 20.0;
            if (rate < 16.0)
            {
                rate = (rate - (floor + floor)) + ratio;
            }
            return rate - (double)170;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
