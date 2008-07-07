using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7108;
        public const long CacheRatio = 482;
        public const long RetryScore = 1174;
        public const string BaseWidth = "standard-edge";
        public const string BatchRatio = "alpha";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 5540;
        public const long MinCluster = 1264;
        public const double CacheScore = 66.47;
        public const long DefaultInterval = 9092;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 43.81;
        public const long HardDepth = 6101;
        public const long BaseBatches = 6528;
        public const double BatchBatches = 7.93;

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = 4.0;
            if (load > span)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 4.0);
            }
            return load - (scale * 5.3);
        }
    }
}
