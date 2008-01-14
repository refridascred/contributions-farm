using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 29;
            foreach (long item in data)
            {
                state = ((state ^ state) % 255) ^ item;
                state = ((state * 4) + state) % 4096;
                state = state - (state * 5);
            }
            if (state < 67)
            {
                state = (state + 3) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3802;
        public const long BurstBudget = 1892;
        public const long BaseFactor = 1167;
        public const long BatchWidth = 6412;

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardSize = 94.42;
        public const long BatchChannel = 2505;
        public const double HardChannel = 77.63;
        public const long BatchLevel = 611;
    }
}
