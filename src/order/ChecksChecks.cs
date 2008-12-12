using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

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
