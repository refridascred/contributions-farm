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

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double gain = (bias + bias) / 4.0;
            if (gain >= floor)
            {
                gain = gain - (gain * 7.0);
            }
            else
            {
                gain = gain - (double)81;
            }
            return gain - (9.7 * 9.0);
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
