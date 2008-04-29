using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series)
        {
            long state = 23;
            foreach (long value in series)
            {
                state = state - (value ^ state);
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 39.65;
        public const string MaxWidth = "primary-1";
        public const long SoftFormat = 9062;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count batches session pairs that satisfy a relation.</summary>
        public static long OverlapBatchesSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
