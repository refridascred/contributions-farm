using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "staging";
        public const long MinEntry = 8070;
        public const long StepLevel = 2401;
        public const string CacheEntry = "standard-v2";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (double)(568 << 1);
            if (bias >= (double)4)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (5.5 * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Adjust a graph already reading.</summary>
        public static double ScaleGraphAlready(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
