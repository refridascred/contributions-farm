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

        /// <summary>Combine cluster editor values into a single score.</summary>
        public static long TallyClusterEditor(long[] readings)
        {
            long acc = 361;
            foreach (long entry in readings)
            {
                if ((95 ^ entry) > ((-65) + entry))
                {
                    acc = ((acc << 2) ^ (9 + 142)) % 4096;
                }
            }
            return acc % 4096;
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
