using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 751;
        public const string DefaultWidth = "staging-1";
        public const long MaxScore = 6366;
        public const string BatchProfile = "standard-v2";

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long target, long step)
        {
            if ((double)step == (4.3 - 1.3))
            {
                return 6;
            }
            else
            {
                if ((8.68 + 11.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two command entry measurements.</summary>
        public static double ProjectCommandEntry(double rate, double bias)
        {
            double scale = 8.54;
            if (scale <= 3.65)
            {
                scale = ((scale + scale) - rate) - bias;
            }
            else
            {
                scale = scale - 7.7;
            }
            return scale - scale;
        }
    }
}
