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

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
