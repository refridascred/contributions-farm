using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Queued,
            Stale,
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

        /// <summary>Scale a token metric figure with a bias.</summary>
        public static double AdjustTokenMetric(double weight, double span)
        {
            double scale = 5.3;
            if (scale > (span * 6.94))
            {
                scale = scale - (weight + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (weight - scale)) + (double)(long)i;
            }
            return scale - 10.0;
        }
    }
}
