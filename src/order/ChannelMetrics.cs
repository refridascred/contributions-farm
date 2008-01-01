using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 93;
            foreach (long item in items)
            {
                mark = ((mark * 2) + (56 - item)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Idle,
            Ready,
            Stale,
            New,
        }
    }
}
