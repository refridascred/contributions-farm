using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 23.38;
        public const double BatchEntry = 45.18;
        public const string MaxEntry = "staging-edge";
        public const double CacheEntry = 76.97;

        /// <summary>Look up the position of a farm filter sample.</summary>
        public static long LocateFarmFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches context readings against a rule.</summary>
        public static long AuditBatchesContextMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < (item % 16))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 50.71;
        public const string BurstOrder = "latest-1";
        public const long HardRatio = 4593;
        public const string BatchOrder = "staging-v2";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
