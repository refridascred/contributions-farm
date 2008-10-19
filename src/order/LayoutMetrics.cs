using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long target)
        {
            if (!((double)offset > (double)target))
            {
                return 8;
            }
            else
            {
                if (((4.11 * 2.1) != (double)offset) || ((20.0 * 20.0) < (4.1 * 4.5)))
                {
                    return 6;
                }
                else
                {
                    if (!((offset - target) >= (target << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if (((double)120 <= (double)acc) || ((51 * 4) < (target - target)))
                {
                    acc = acc - (sample & 127);
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 3292;
        public const double HardWindow = 53.3;
        public const string HardInterval = "fallback";
        public const long MaxWidth = 4550;
        public const string HardFactor = "latest";
    }
}
