using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySpan = 1255;
        public const string BatchProfile = "local-edge";
        public const long StepSize = 6568;
        public const long BurstProfile = 1040;
        public const long BaseProfile = 3393;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = state + (long)i;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double gain = (offset - bias) - (bias - bias);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
