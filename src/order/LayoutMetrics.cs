using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a graph token reading.</summary>
        public static double ProjectGraphToken(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (double)8)
            {
                bias = (bias - ratio) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (20.0 / 8.0))
            {
                ratio = (ratio + (scale + 3.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (scale + ratio)) - (double)(long)i;
            }
            return ratio - (8.0 + scale);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
