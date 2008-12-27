using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 1010;
        public const double WindowToken = 51.25;
        public const long RetrySize = 2031;
        public const double WindowBudget = 17.26;

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultSize = 13.17;
        public const string LimitContext = "stable-v2";
        public const long RetryInterval = 5130;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > (28 - seed))
                {
                    matches = (matches + 2) + entry;
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
