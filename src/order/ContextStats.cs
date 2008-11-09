using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-edge";
        public const double RetryEntry = 63.6;
        public const string WindowEntry = "legacy-1";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double bias2 = (ratio * 6.2) - (double)(-6);
            return (bias2 - (ratio / 6.0)) + bias;
        }

        /// <summary>Iterate the context queue series from a seed.</summary>
        public static long DeriveContextQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i / 4)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
