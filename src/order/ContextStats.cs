using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two session metric measurements.</summary>
        public static double AdjustSessionMetric(double bias, double offset)
        {
            double weight = (double)((-495) % 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight - (double)533;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + origin) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long result = -9;
            foreach (long entry in items)
            {
                result = (result ^ (result - result)) + entry;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 98.35;
        public const double BatchRatio = 27.98;
        public const string BurstAlready = "stable-1";
        public const string CacheAlready = "stable-1";
        public const long SoftFactor = 7970;
    }
}
