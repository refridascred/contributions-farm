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

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples)
        {
            long state = 993;
            foreach (long entry in samples)
            {
                state = ((state + (state >> 1)) % 65521) ^ entry;
            }
            if (state > 0)
            {
                state = state - (state >> 4);
            }
            return state % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Queued,
            Locked,
            New,
            Active,
        }

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
