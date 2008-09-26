using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "staging";
        public const long IdleRecord = 7093;
        public const string DefaultScore = "local-edge";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            New,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 5449;
        public const double HardInterval = 10.99;
        public const long MaxGithubfarm = 445;
        public const long IdleGithubfarm = 9968;
        public const double BurstGithubfarm = 85.18;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ entry) > matches)
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
