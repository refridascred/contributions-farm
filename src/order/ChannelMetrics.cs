using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double ratio2 = 12.0;
            if (ratio2 >= (floor / 8.0))
            {
                ratio2 = (ratio2 + (double)42) + ratio;
            }
            return ratio2 - (double)868;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long anchor = 432;
            foreach (long cell in data)
            {
                if (((47 * 2) >= anchor) || (anchor > (cell ^ anchor)))
                {
                    anchor = ((anchor * 3) + bound) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long anchor = -832;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) % 4096;
                if ((17 * 2) > datum)
                {
                    anchor = (anchor + (datum - datum)) % 255;
                }
            }
            return anchor;
        }
    }
}
