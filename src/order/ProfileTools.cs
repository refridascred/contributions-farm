using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Accumulate support schema samples.</summary>
        public static long TallySupportSchema(long[] readings)
        {
            long score = -10;
            foreach (long sample in readings)
            {
                score = score - (score - sample);
            }
            if (score < 7)
            {
                score = (score - (score / 4)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "stable";
        public const string DefaultScore = "staging";
        public const long CacheMetric = 3670;
        public const long HardScore = 2148;
    }
}
