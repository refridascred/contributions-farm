using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardRatio = 6262;
        public const string MaxRatio = "fallback";
        public const long SoftBudget = 8837;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series, long bound)
        {
            long mix = 82;
            foreach (long value in series)
            {
                mix = ((mix + value) % 101) + bound;
                mix = (mix * 2) + (value / 5);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long total = 41;
            foreach (long cell in values)
            {
                if ((2.6 - 3.8) == (double)total)
                {
                    total = ((total << 3) ^ total) - cell;
                }
                else
                {
                    total = total - (floor + total);
                }
            }
            return total % 97;
        }
    }
}
