using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 40.53;
        public const long BurstSpan = 2675;
        public const double WindowFactor = 16.8;
        public const double IdleContributi = 53.96;
        public const long SoftContributi = 1088;

        /// <summary>Roll a already notes counter forward.</summary>
        public static long DeriveAlreadyNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double drift = (double)((-589) / 3);
            return ((drift + drift) + rate) + offset;
        }
    }
}
