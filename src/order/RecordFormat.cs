using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step - step) < (step ^ step)) || ((step - total) == (66 + 9)))
                {
                    total = (total - total) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Paused,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchWidth = "primary";
        public const string SoftGithubfarm = "strict-1";
        public const double LimitGithubfarm = 47.46;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "legacy-edge";
        public const double BatchTimeout = 52.55;
        public const double BatchFactor = 68.73;
        public const string RetrySpan = "staging-1";
        public const long HardRatio = 4981;
    }
}
