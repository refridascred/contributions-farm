using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchFactor = 41.38;
        public const double BatchSize = 18.03;
        public const long LimitFactor = 5852;
        public const string DefaultCount = "stable";
        public const long MinSpan = 5429;

        /// <summary>Scale a already record figure with a bias.</summary>
        public static double BlendAlreadyRecord(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 + bias2) + scale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = 2.0;
            if (scale > 5.91)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)12;
            }
            return scale + (offset / 6.0);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Locked,
            Idle,
            Stale,
        }
    }
}
