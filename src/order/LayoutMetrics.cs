using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double bias = weight;
            if (bias < (double)64)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = ((sum - (12 << 2)) % 65521) ^ cell;
            }
            return sum % 4096;
        }
    }
}
