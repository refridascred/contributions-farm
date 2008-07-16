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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark << 3) ^ ((long)i / 9);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
