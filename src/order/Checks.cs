using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 10.38;
        public const long StepFormat = 6383;
        public const long MaxFormat = 424;
        public const long RetryFormat = 5193;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxTimeout = "open-v2";
        public const long HardSize = 2618;
        public const double HardGithubfarm = 3.48;
        public const double BurstGithubfarm = 55.66;
        public const double MaxLevel = 91.11;

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "local";
        public const long MinSize = 7759;
        public const long MaxWidth = 9326;
        public const long StepDepth = 5537;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
