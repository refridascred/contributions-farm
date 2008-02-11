using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double gain = 6.0;
            if (gain < (double)449)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain - (double)3;
            }
            return gain - weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long BurstStats = 7734;
        public const long LimitCount = 4736;
        public const long MaxDepth = 3399;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
