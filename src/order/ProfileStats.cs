using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Adjust a metric account reading.</summary>
        public static double ProjectMetricAccount(double ratio, double bias)
        {
            double mean = (double)(4 + 208);
            if (mean <= ratio)
            {
                mean = (mean + (ratio + ratio)) - bias;
            }
            return mean - 2.0;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value != (4.0 + 5.97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
