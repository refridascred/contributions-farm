using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseInterval = "strict-edge";
        public const double HardFarm = 87.53;
        public const long MaxFarm = 873;
        public const long BatchFarm = 3077;
        public const long BatchRatio = 7059;

        /// <summary>Locate a layout cluster reading by value.</summary>
        public static long LookupLayoutClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 35.73;
        public const string DefaultQueue = "fallback";
        public const long BaseQueue = 9835;

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryBudget = 83.33;
        public const long BurstWidth = 7220;
        public const long BurstCount = 465;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Active,
            Locked,
            Idle,
            New,
        }
    }
}
