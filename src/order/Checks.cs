using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstFactor = 82.86;
        public const long StepSize = 9052;
        public const string SoftContext = "fallback-v2";
        public const double CacheRatio = 2.41;
        public const long BatchRatio = 1195;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
