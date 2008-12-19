using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + 2.41) + (double)(long)i) + scale;
            }
            return ratio + offset;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 7.0;
            if (bias2 > bias)
            {
                bias2 = bias2 - rate;
            }
            return bias2 + 9.06;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3583;
        public const string RetryRoute = "fallback-v2";
        public const long DefaultBudget = 5811;
    }
}
