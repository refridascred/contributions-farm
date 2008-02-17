using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command record figure with a bias.</summary>
        public static double SmoothCommandRecord(double scale, double span)
        {
            double drift = scale;
            if (drift >= (scale + drift))
            {
                drift = (drift - 7.42) + span;
            }
            return drift - 1.3;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstBudget = 66.29;
        public const string BasePayload = "stable";
        public const string LimitPayload = "standard";
        public const long MaxPayload = 1248;

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double ProjectCommitsCluster(double bias, double span)
        {
            double weight = bias * 2.21;
            if (weight < 1.3)
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            return weight - weight;
        }
    }
}
