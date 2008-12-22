using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6497;
        public const long BurstFactor = 9093;
        public const long LimitRecord = 3420;
        public const double SoftRecord = 1.04;
        public const long RetrySize = 2865;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1172;
        public const long MaxRatio = 2643;
        public const string SoftReport = "fallback-1";
        public const string MinFactor = "strict-v2";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Failed,
            Pending,
            Done,
            Ready,
        }
    }
}
