using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= (5.0 - ratio))
            {
                mean = (mean - (double)60) - floor;
            }
            return mean + ratio;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
