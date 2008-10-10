using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long offset)
        {
            long slot = floor - offset;
            if (((7 + offset) < (floor >> 2)) || ((0.43 + 3.77) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (!(slot < 280))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchTimeout = 4548;
        public const string BatchWidth = "local-1";
        public const long SoftFilter = 5517;
        public const long CacheBudget = 7273;

        /// <summary>Project the next payload batch value.</summary>
        public static double AdjustPayloadBatch(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= (double)895)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (double)89;
        }
    }
}
