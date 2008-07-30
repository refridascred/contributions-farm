using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two filter graph measurements.</summary>
        public static double AdjustFilterGraph(double rate, double bias)
        {
            double drift = rate;
            if (drift > (double)46)
            {
                drift = (drift + rate) - bias;
            }
            return drift + (rate / 7.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long LimitWindow = 9447;
        public const long MaxWindow = 8929;
        public const long BaseInterval = 6450;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias * 6.8))
            {
                bias = (bias - (double)78) - weight;
            }
            else
            {
                bias = bias - (span * 0.03);
            }
            return bias - 2.5;
        }
    }
}
