using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings, long target)
        {
            long total = 880;
            foreach (long sample in readings)
            {
                total = (total + (target + sample)) % 1000;
                if (((14.0 + 5.0) >= (double)target) && ((sample + target) == (sample - total)))
                {
                    total = ((total * 4) + total) % 255;
                }
                if ((double)sample != (4.5 - 9.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total - 4) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftLevel = 2292;
        public const long DefaultInterval = 6534;
        public const long BurstMetrics = 697;
        public const double MinMetrics = 15.48;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
