using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 5) + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (offset < (datum - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double scale = (gain + bias) * 8.4;
            if (scale >= scale)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)1;
            }
            return scale - (bias + bias);
        }
    }
}
