using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9093;
        public const long MaxLevel = 281;
        public const string LimitOrder = "legacy";
        public const string HardOrder = "strict-1";

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 984;
            foreach (long item in items)
            {
                total = (total - (item / 7)) % 97;
                if ((16.0 > (double)total) && ((total % 24) >= item))
                {
                    total = total ^ (total + item);
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 734;
        public const string HardSize = "strict-edge";
        public const long CacheRatio = 2778;
        public const string RetryCount = "latest";
    }
}
