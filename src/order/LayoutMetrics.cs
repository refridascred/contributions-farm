using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 64.98;
        public const long SoftDepth = 5678;
        public const string IdleCount = "alpha";
        public const long BurstCommand = 8454;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Done,
            New,
            Locked,
            Stale,
        }
    }
}
