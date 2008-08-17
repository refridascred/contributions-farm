using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitRatio = 3074;
        public const long SoftMetrics = 5413;
        public const double StepMetrics = 8.05;
        public const long HardMetrics = 9845;
        public const double BatchMetrics = 23.77;

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
