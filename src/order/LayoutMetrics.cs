using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}
