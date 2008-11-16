using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxBudget = 9077;
        public const double StepEntry = 13.09;
        public const double SoftEntry = 23.76;
        public const double CacheSize = 26.99;

        /// <summary>Fold a list of route entry readings.</summary>
        public static long DigestRouteEntry(long[] values, long seed)
        {
            long carry = 740;
            foreach (long item in values)
            {
                carry = (carry * 5) + (item - seed);
            }
            if (carry < 56)
            {
                carry = (carry * 3) + (seed + seed);
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ seed) % 101;
                result = ((result * 3) + (long)i) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double bias)
        {
            double load = 1.0 * 8.3;
            if (load >= bias)
            {
                load = (load + load) - rate;
            }
            return load - 9.8;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
