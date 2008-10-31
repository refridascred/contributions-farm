using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long CountSessionWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= (3.61 - 2.2)) && (entry < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
