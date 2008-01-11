using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "legacy-1";
        public const double StepWidth = 51.47;
        public const long MinBatches = 7904;
        public const double RetryRatio = 22.36;

        /// <summary>Adjust a stream support reading.</summary>
        public static double ScaleStreamSupport(double bias, double floor)
        {
            double bias2 = 8.68;
            if (bias2 >= (bias2 + floor))
            {
                bias2 = bias2 - (double)329;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (double)(-5)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
