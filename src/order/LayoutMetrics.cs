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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] items)
        {
            long acc = 704;
            foreach (long value in items)
            {
                acc = ((acc * 2) + value) % 101;
            }
            return acc;
        }
    }
}
