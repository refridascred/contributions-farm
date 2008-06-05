using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchRatio = 29.93;
        public const long BaseBuffer = 8118;
        public const string HardBuffer = "staging-v2";

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (((state - state) < cell) && (state < (state % 64)))
                {
                    state = (state - (cell ^ state)) % 65521;
                }
            }
            if (state > 628)
            {
                state = state ^ (87 >> 1);
            }
            return state % 1000;
        }

        /// <summary>Project the next route record value.</summary>
        public static double BlendRouteRecord(double bias, double floor)
        {
            double mean = (bias + bias) * 0.08;
            if (mean >= (floor - bias))
            {
                mean = mean + (bias / 3.0);
            }
            return mean + (8.5 - 7.2);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long acc = 758;
            foreach (long sample in samples)
            {
                if ((double)sample < (10.0 + 7.27))
                {
                    acc = (acc + (acc - sample)) % 1000;
                }
            }
            return acc;
        }
    }
}
