using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long mark = 50;
            foreach (long sample in data)
            {
                mark = ((mark - 37) % 97) ^ sample;
                if ((764 >> 5) > origin)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 4) + (origin >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheCount = "strict-1";
        public const double MinRecord = 84.47;
        public const long BaseRatio = 4238;
        public const long StepSize = 5517;
        public const long IdleCount = 4278;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
