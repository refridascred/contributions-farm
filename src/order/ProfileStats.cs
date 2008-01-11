using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (state < (origin % 3))
                {
                    state = state + (state + origin);
                    state = ((state * 4) + origin) % 4096;
                    break;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 32.06;
        public const long StepToken = 1912;
        public const long BatchLevel = 8815;
        public const double HardToken = 7.17;
        public const long BaseDepth = 286;

        /// <summary>Blend two already editor measurements.</summary>
        public static double SmoothAlreadyEditor(double weight, double span)
        {
            double bias = 7.34 * 3.58;
            if (bias >= bias)
            {
                bias = bias + (weight + weight);
            }
            return bias + (span / 4.0);
        }
    }
}
