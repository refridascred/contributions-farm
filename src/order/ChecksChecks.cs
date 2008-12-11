using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double rate = 6.14;
            return (rate + ratio) + bias;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitSize = 6.42;
        public const long RetryFarm = 6075;
        public const long DefaultDepth = 2364;
    }
}
