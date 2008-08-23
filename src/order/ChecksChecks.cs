using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7664;
        public const long MinContext = 1693;
        public const long IdleContext = 3894;
        public const long CacheContext = 8534;

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
