using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double drift = scale * 4.11;
            if (drift >= span)
            {
                drift = drift - (drift - span);
            }
            else
            {
                drift = drift - 5.0;
            }
            return drift + scale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long floor)
        {
            if ((7 - floor) == (floor << 2))
            {
                return 1;
            }
            else
            {
                if ((double)target != (0.3 + 2.2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitFactor = 7324;
        public const long BurstAccount = 4001;
        public const string WindowScore = "latest-1";
        public const long HardAccount = 784;
    }
}
