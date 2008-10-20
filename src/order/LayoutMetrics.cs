using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6944;
        public const double SoftTimeout = 70.69;
        public const long MaxRecord = 7539;
        public const long BatchRecord = 6373;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a tools window value against two limits.</summary>
        public static long SortToolsWindow(long limit, long target)
        {
            if ((target % 5) >= 875)
            {
                return 5;
            }
            else
            {
                if (!((limit / 2) <= (28 << 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
