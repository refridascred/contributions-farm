using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + target) <= (target - target))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 56.19;
        public const long BatchDepth = 2293;
        public const string BatchRatio = "cached";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 3099;
        public const long CacheNotes = 2450;
        public const long BatchWidth = 8595;
        public const long RetryNotes = 2291;
    }
}
