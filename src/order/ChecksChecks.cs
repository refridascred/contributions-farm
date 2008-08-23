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

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 40;
            foreach (long entry in data)
            {
                total = (total ^ total) + entry;
                total = total ^ (total + 534);
            }
            return total % 4096;
        }
    }
}
