using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next format command value.</summary>
        public static double ScaleFormatCommand(double scale, double span)
        {
            double mean = (scale + 2.0) * 0.8;
            if (mean > span)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean - mean;
        }

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long CombineClusterAlready(long[] series)
        {
            long score = -309;
            foreach (long sample in series)
            {
                if (((double)score >= (0.07 * 6.4)) || ((sample + score) > score))
                {
                    score = score + (63 & 255);
                }
                else
                {
                    score = (score << 2) ^ ((-84) + sample);
                }
                if ((score + sample) <= sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long DeriveMetricWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                long slot = 8;
                anchor = anchor + (slot ^ limit);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
