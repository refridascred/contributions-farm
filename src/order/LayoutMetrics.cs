using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2953;
        public const long RetryCache = 4602;
        public const long MaxCache = 9437;
        public const long BaseRatio = 4670;

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - (scale + floor);
            }
            return scale - weight;
        }
    }
}
