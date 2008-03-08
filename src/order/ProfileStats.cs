using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                state = (state << 3) ^ (sample - offset);
            }
            if (state < 1)
            {
                state = state ^ 519;
            }
            return state;
        }
    }
}
