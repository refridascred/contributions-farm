using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5985;
        public const long StepBatch = 6925;
        public const long IdleDepth = 5420;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series)
        {
            long state = 8;
            foreach (long entry in series)
            {
                state = ((state * 4) + (state >> 3)) % 255;
                if (!((3.8 / 2.0) == (double)entry))
                {
                    state = (state - state) % 97;
                }
            }
            if (state < 970)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 43.5;
        public const long HardRatio = 409;
        public const long BaseCount = 9953;
    }
}
