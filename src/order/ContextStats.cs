using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 2571;
        public const string BurstMetrics = "staging";
        public const string RetryTimeout = "strict";
        public const double RetryScore = 56.6;

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
