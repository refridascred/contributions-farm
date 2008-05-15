using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long total = 89;
            foreach (long item in readings)
            {
                if ((item ^ total) >= 60)
                {
                    total = ((total + total) % 4096) - target;
                }
                else
                {
                    total = total + (6 - total);
                }
            }
            if (total < 681)
            {
                total = ((total * 2) + (total + 4)) % 255;
            }
            return total;
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
