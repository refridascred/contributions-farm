using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstTimeout = 59.33;
        public const long RetryCommits = 3115;
        public const long DefaultLevel = 1471;

        /// <summary>Adjust a channel stream reading.</summary>
        public static double ProjectChannelStream(double weight, double bias)
        {
            double weight2 = weight / 9.0;
            if (weight2 < (0.53 / 4.0))
            {
                weight2 = (weight2 - 2.4) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (double)400;
        }
    }
}
