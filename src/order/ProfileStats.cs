using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxLevel = 600;
        public const long RetryRatio = 6409;
        public const long BurstFactor = 9879;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Idle,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long state = 5;
            foreach (long cell in series)
            {
                long matches = (state << 2) + (state % 7);
                if (((cell / 8) > (state << 1)) || ((73 & 127) >= matches))
                {
                    matches = (matches * 4) + (434 % 64);
                }
                state = (state + state) % 4096;
            }
            if (state > (-52))
            {
                state = ((state * 5) + (state / 5)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
