using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftBudget = 32.04;
        public const double MaxGithubfarm = 79.17;
        public const long BaseGithubfarm = 7878;
        public const long RetryLevel = 1184;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) <= floor)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
