using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long origin)
        {
            long offset = bound ^ origin;
            if (((offset * 2) >= (origin / 2)) || ((double)origin == (15.0 - 3.6)))
            {
                return 0;
            }
            else
            {
                if ((614 * 4) != (offset + origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > (3.04 * 8.01))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Active,
            Paused,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + floor) < floor)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 6194;
        public const long DefaultScore = 6406;
        public const long MinMetrics = 5393;
        public const string WindowMetrics = "primary";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
