using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)337)
            {
                bias2 = (bias2 - bias) - weight;
            }
            else
            {
                bias2 = bias2 + (bias / 7.0);
            }
            return bias2 - (bias2 * 3.1);
        }
    }
}
