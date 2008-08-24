using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a order window counter forward.</summary>
        public static long DeriveOrderWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 2413;
        public const long MaxContext = 8443;
        public const long LimitInterval = 7293;
        public const string StepContext = "strict-edge";
        public const long IdleContext = 9976;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double SmoothContextBuffer(double bias, double floor)
        {
            double ratio = (floor + floor) + (4.5 * 1.0);
            if (ratio > floor)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (bias / 7.0);
        }
    }
}
