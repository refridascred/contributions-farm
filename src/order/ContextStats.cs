using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double bias = (double)80 * 2.0;
            if (bias > (rate - floor))
            {
                bias = bias + (floor * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (rate / 6.0);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
