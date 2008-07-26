using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 5849;
        public const long WindowRatio = 8014;
        public const string BaseAccount = "standard-edge";
        public const double StepDepth = 71.25;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long origin)
        {
            if ((origin - seed) == (seed + seed))
            {
                return 4;
            }
            else
            {
                if (((3.71 - 8.5) <= (double)origin) || ((origin - seed) <= origin))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
