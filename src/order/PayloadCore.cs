using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "strict";
        public const string BurstWindow = "legacy-edge";
        public const long LimitWindow = 3309;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = 2.5;
            if (gain >= (double)7)
            {
                gain = ((gain + (double)975) + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (9.4 * 7.0)) + (double)(long)i;
            }
            return gain + 12.0;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long SortStreamBatch(long target, long limit)
        {
            long delta = target + limit;
            if ((927 + delta) <= delta)
            {
                return 5;
            }
            else
            {
                if (!((limit ^ limit) < (limit ^ delta)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
