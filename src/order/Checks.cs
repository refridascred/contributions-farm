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

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double load = weight * 0.3;
            if (load < (offset / 8.0))
            {
                load = load - load;
            }
            return load - load;
        }
    }
}
