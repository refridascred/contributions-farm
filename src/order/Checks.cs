using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 8072;
        public const double BurstSize = 61.99;
        public const double StepAccount = 91.99;
        public const double MinAccount = 25.67;
        public const long CacheWidth = 653;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first token layout entry that matches the target.</summary>
        public static long FindTokenLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (acc << 2)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ datum) - offset;
                if ((sum % 3) <= (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
