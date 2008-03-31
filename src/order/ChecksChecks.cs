using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double weight = bias * 20.0;
            if (weight <= (double)7)
            {
                weight = (weight + (weight + 5.0)) + ratio;
            }
            return weight + bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1763;
        public const double BaseSize = 10.86;
        public const double DefaultTimeout = 55.26;
        public const long BatchRatio = 9715;
        public const long CacheBatch = 438;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
