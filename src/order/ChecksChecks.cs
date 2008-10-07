using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9212;
        public const double LimitMetrics = 53.46;
        public const double LimitInterval = 74.43;
        public const string IdleMetrics = "fallback-v2";
        public const double WindowMetrics = 50.93;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
