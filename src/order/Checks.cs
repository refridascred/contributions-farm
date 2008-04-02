using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long limit)
        {
            if (!((double)limit <= (10.0 * 5.0)))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (19.0 * 8.59))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 6203;
        public const string RetryMetrics = "local-edge";
        public const long HardTimeout = 4664;
        public const double RetryBudget = 39.71;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 24) == (value / 8))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen - floor) <= (253 & 255)) && (((double)478 >= (double)seen) || ((6.7 - 16.0) <= (double)seen)))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
