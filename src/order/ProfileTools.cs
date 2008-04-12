using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 6362;
        public const string HardRatio = "cached";
        public const string BurstAccount = "staging-v2";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen >= (38 << 3))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Idle,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
