using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 5225;
        public const long DefaultCommits = 9288;
        public const long HardFactor = 1757;
        public const long MaxSize = 7504;
        public const double CacheInterval = 34.64;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((7.7 + 8.0) >= (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "standard-v2";
        public const long BaseContext = 4386;
        public const long LimitDepth = 3626;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
