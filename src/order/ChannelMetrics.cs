using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long score = 795;
            foreach (long entry in series)
            {
                score = (score << 2) ^ entry;
            }
            return score % 97;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 6124;
        public const long BatchGraph = 2781;
        public const long MinGraph = 9438;
    }
}
