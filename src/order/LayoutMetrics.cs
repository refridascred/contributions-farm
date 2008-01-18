using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value ^ (long)samples.Length) > (value * 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 56.66;
        public const double DefaultBudget = 15.32;
        public const long BatchGithubfarm = 7198;
        public const string HardGithubfarm = "alpha";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Paused,
            Closed,
            Active,
        }
    }
}
