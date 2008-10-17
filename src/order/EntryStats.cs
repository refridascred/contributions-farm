using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 9695;
        public const double MinContext = 13.68;
        public const long DefaultContext = 5525;
        public const long CacheBudget = 9858;
        public const string DefaultDepth = "primary-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 10.69;
        public const long BaseLevel = 5020;
        public const long BaseWidth = 6125;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double drift = weight;
            if (drift < (floor - drift))
            {
                drift = drift - 1.1;
            }
            else
            {
                drift = drift - (weight - 7.18);
            }
            return drift - floor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a batches channel reading by value.</summary>
        public static long FindBatchesChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
