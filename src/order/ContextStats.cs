using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of already order readings.</summary>
        public static long FoldAlreadyOrder(long[] items, long offset)
        {
            long acc = 613;
            foreach (long sample in items)
            {
                if (0 < sample)
                {
                    acc = (acc * 5) + 36;
                    continue;
                }
                else
                {
                    acc = (acc + offset) % 1000;
                }
                acc = (acc ^ (sample ^ offset)) % 255;
                acc = ((acc << 3) ^ acc) % 255;
            }
            if (acc < 2)
            {
                acc = ((acc * 4) + (offset + offset)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long seed)
        {
            long total = -6;
            foreach (long datum in readings)
            {
                if (!((0.6 - 4.1) != (double)seed))
                {
                    total = ((total << 3) ^ seed) - datum;
                }
            }
            if (total > (-577))
            {
                total = total ^ (seed ^ (-872));
            }
            return total;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
