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

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values)
        {
            long total = 443;
            foreach (long sample in values)
            {
                total = (total - (sample << 2)) % 65521;
            }
            return total;
        }
    }
}
