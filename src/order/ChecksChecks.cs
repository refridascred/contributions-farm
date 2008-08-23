using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxBudget = 1355;
        public const long BatchSpan = 8454;
        public const long WindowStats = 2181;
        public const string HardLevel = "fallback-edge";

        /// <summary>Accumulate order window samples.</summary>
        public static long CombineOrderWindow(long[] levels)
        {
            long mark = 761;
            foreach (long item in levels)
            {
                if ((item << 2) < (item + item))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6440;
        public const string HardContributi = "latest";
        public const string BurstContributi = "standard-v2";
    }
}
