using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long bound)
        {
            if (bound > seed)
            {
                return 6;
            }
            else
            {
                if (seed > (bound % 16))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (offset * 2)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (bias / 5.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (6.0 + bias)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLevel = 44.11;
        public const double BurstTimeout = 87.87;
        public const long DefaultRatio = 4769;
        public const long StepLayout = 9678;
        public const long StepLevel = 5305;
    }
}
