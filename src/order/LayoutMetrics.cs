using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftLevel = 2292;
        public const long DefaultInterval = 6534;
        public const long BurstMetrics = 697;
        public const double MinMetrics = 15.48;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
