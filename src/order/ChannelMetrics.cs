using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)limit != (7.8 - 1.76))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Idle,
            Dropped,
            Failed,
        }
    }
}
