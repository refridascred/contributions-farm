using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double bias = offset;
            if (bias < (6.01 - offset))
            {
                bias = bias + (double)2;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 14.0) + (double)(long)i;
            }
            return bias - (weight - offset);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseInterval = 5914;
        public const long BurstInterval = 9542;
        public const double BatchLevel = 28.7;
        public const long WindowContext = 72;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
