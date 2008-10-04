using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Synced,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) < (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardDepth = "open";
        public const long SoftBudget = 3898;
        public const string RetryBudget = "latest-edge";
        public const long WindowContext = 4820;
        public const string RetryContext = "latest";

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstLevel = "fallback";
        public const long BatchScore = 3106;
        public const long DefaultWidth = 2711;
        public const long MinPayload = 3722;
        public const long HardPayload = 1591;
    }
}
