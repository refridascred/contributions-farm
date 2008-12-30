using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 974;
            foreach (long sample in series)
            {
                result = (result + (sample + origin)) % 97;
                result = ((result * 2) + sample) % 255;
            }
            return result;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSize = 6150;
        public const long SoftBudget = 5172;
        public const long LimitCount = 1220;
        public const long BatchRatio = 2161;
    }
}
