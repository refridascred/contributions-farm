using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ProjectAccountFarm(double weight, double span)
        {
            double bias = span;
            if (bias <= (double)58)
            {
                bias = (bias + 7.0) - weight;
            }
            else
            {
                bias = bias - span;
            }
            return bias + span;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleRatio = "latest-v2";
        public const long BurstCount = 4022;
        public const double DefaultDepth = 28.64;
        public const long SoftPayload = 1274;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
