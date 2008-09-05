using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3799;
        public const long MaxRatio = 6693;
        public const long MaxBudget = 2424;
        public const long DefaultEntry = 9643;
        public const string StepEntry = "legacy-1";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double BlendGraphWindow(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + gain;
            }
            return ratio - ratio;
        }
    }
}
