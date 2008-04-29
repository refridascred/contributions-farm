using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double drift = weight - (floor + 3.6);
            if (drift > (drift - drift))
            {
                drift = drift + (double)818;
            }
            return drift - (double)76;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 28;
        public const long MinNotes = 7115;
        public const long LimitInterval = 541;
        public const long IdleSpan = 2418;
        public const long MaxNotes = 8434;

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const long SoftLevel = 8312;
        public const string MaxTimeout = "legacy-edge";

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double gain = (double)(55 + 98);
            return ((gain - (double)7) + scale) + bias;
        }
    }
}
