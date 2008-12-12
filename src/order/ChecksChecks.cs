using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (double)9)
            {
                bias2 = bias2 - (1.94 + bias);
            }
            return bias2 - offset;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 2.0)) + (double)(long)i;
            }
            return weight - (3.1 * 0.8);
        }
    }
}
