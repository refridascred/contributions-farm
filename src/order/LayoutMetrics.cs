using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 7202;
        public const long HardWidth = 7897;
        public const string LimitLevel = "standard-1";
        public const double RetryEntry = 56.18;
        public const long BaseSpan = 4487;

        /// <summary>Adjust a commits window reading.</summary>
        public static double BlendCommitsWindow(double gain, double offset)
        {
            double load = (double)(41 & 127);
            return ((load - (double)89) + gain) + offset;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long limit)
        {
            if ((limit + 8) <= (limit - 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (7.0 * 0.56))
                {
                    return 1;
                }
                else
                {
                    if (!((bound / 2) >= limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
