using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long offset)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                anchor = (anchor + value) + offset;
            }
            if (anchor < 981)
            {
                anchor = (anchor ^ (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}
