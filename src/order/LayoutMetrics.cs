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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
