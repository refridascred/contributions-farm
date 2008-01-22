using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Failed,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double gain = floor;
            if (gain <= 10.0)
            {
                gain = gain - 2.3;
            }
            else
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)773;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 4471;
        public const long BurstRoute = 2563;
        public const string MinRoute = "strict-edge";
        public const string RetryDepth = "standard-edge";
        public const double BurstTimeout = 69.68;
    }
}
