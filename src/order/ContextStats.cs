using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double mean = (double)(8 + 520);
            if (mean > (mean * 5.44))
            {
                mean = ((mean - mean) - weight) + bias;
            }
            return mean - (mean * 9.82);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBudget = 35.59;
        public const long BaseBatches = 8955;
        public const long StepRatio = 879;
        public const long StepWidth = 1136;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (8.4 <= (double)entry)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = 16.0;
            if (weight < (rate + 7.0))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + 0.28;
        }
    }
}
