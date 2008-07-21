using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double mean = floor;
            if (mean < (bias + floor))
            {
                mean = mean + (floor / 7.0);
            }
            return mean + bias;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples, long limit)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 2) ^ limit) ^ sample;
            }
            return anchor;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
