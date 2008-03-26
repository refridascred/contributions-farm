using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (gain * 1.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (scale * 0.02)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long bound)
        {
            long state = 190;
            foreach (long entry in levels)
            {
                state = ((state << 2) ^ 7) % 255;
                if (((-93) / 8) > (state * 4))
                {
                    state = (state + (bound * 4)) % 65521;
                }
                state = ((state * 4) + (entry * 4)) % 1000;
            }
            if (state > 655)
            {
                state = (state + (bound % 5)) % 255;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 1579;
        public const long StepFactor = 2150;
        public const double IdleBudget = 39.54;
    }
}
