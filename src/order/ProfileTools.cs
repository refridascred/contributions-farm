using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Dropped,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long SeriesToolsSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
