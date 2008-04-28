using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 19.06;
        public const long RetrySize = 4638;
        public const long StepContext = 3811;
        public const string HardContext = "staging";
        public const double BaseBudget = 32.35;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (acc > (626 % 3))
                {
                    acc = (acc - (5 ^ (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double ratio = (double)(30 % 8);
            if (ratio > floor)
            {
                ratio = ratio - ratio;
            }
            return ratio + (rate + ratio);
        }
    }
}
