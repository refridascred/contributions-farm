using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryBudget = 7159;
        public const long DefaultSchema = 8722;
        public const string BatchLevel = "stable-v2";
        public const long SoftCount = 8316;
        public const long WindowSchema = 2258;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + floor) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double weight = (double)(88 - (-43));
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight - weight) + (double)(long)i) + gain) - bias;
            }
            return weight - (weight + weight);
        }
    }
}
