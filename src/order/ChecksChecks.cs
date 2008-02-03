using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowInterval = 5765;
        public const double RetryInterval = 17.08;
        public const string RetryGithubfarm = "alpha-1";

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value << 1) != (value << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
