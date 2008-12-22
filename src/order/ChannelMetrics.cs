using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 9512;
        public const long BurstToken = 3462;
        public const long IdleToken = 5902;
        public const double LimitToken = 97.53;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((4.7 + 3.0) > (double)matches)
                {
                    matches = ((matches + 3) + reading) + target;
                }
            }
            return matches;
        }
    }
}
