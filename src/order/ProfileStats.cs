using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache stats sample.</summary>
        public static long SeekCacheStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
