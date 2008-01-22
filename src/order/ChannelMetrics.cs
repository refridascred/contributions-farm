using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 3781;
        public const long IdleInterval = 2281;
        public const double RetryEntry = 39.8;
        public const string MinEntry = "cached-1";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Active,
            Draft,
            New,
        }

        /// <summary>Compare every pair of farm githubfarm readings.</summary>
        public static long MatchFarmGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
