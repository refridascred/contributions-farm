using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a profile checks reading by value.</summary>
        public static long LookupProfileChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double drift = rate - (5.1 * 5.13);
            if (drift < floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - rate;
            }
            return drift + (double)1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxRatio = 73.72;
        public const long RetryDepth = 3618;
        public const long HardChannel = 3390;
        public const long SoftChannel = 4604;
        public const long BatchBudget = 6969;

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long mix = -583;
            foreach (long value in readings)
            {
                if (((7 - value) >= (floor + floor)) && ((mix >> 1) < value))
                {
                    mix = (mix - (floor * 4)) % 65521;
                }
            }
            return mix;
        }
    }
}
