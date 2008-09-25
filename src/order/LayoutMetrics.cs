using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5877;
        public const long LimitWidth = 7224;
        public const string BaseFormat = "strict";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first support layout entry that matches the target.</summary>
        public static long LookupSupportLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
