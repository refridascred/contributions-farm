using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context session values into a single score.</summary>
        public static long TotalContextSession(long[] series, long step)
        {
            long mark = 3;
            foreach (long item in series)
            {
                mark = ((((mark * 2) + 860) % 101) ^ item) - step;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2428;
        public const long HardWidth = 1904;
        public const long StepInterval = 3537;
    }
}
