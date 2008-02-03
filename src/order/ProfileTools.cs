using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryLevel = 77.37;
        public const long BaseTimeout = 1969;
        public const string BurstTimeout = "fallback";
        public const long DefaultSize = 9262;
        public const long RetryBudget = 8105;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 4369;
        public const double IdleInterval = 36.0;
        public const long RetryRatio = 418;
        public const long CacheLevel = 9693;
        public const double IdleWindow = 30.32;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
