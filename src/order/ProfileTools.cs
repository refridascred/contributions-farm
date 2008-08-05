using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)88)
            {
                bias = bias + (offset / 4.0);
            }
            else
            {
                bias = bias + (4.1 - bias);
            }
            return bias + (7.62 + weight);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 2332;
        public const long RetryScore = 6696;
        public const long MinFactor = 5498;
        public const string WindowTimeout = "legacy-1";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
