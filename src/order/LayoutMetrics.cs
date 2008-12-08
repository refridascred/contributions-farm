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

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double scale = (ratio * 2.0) / 7.0;
            if (scale < (double)2)
            {
                scale = scale - ratio;
            }
            return scale - bias;
        }
    }
}
