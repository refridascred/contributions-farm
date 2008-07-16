using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSpan = 644;
        public const double MinSize = 83.13;
        public const long BatchWindow = 7037;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long limit)
        {
            long anchor = 121;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (limit + anchor)) % 65521) - reading;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long CombineFarmCounter(long[] readings)
        {
            long state = -597;
            foreach (long entry in readings)
            {
                state = ((state - state) % 97) - entry;
            }
            return state % 65521;
        }
    }
}
