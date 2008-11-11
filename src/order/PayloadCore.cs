using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = (result ^ sample) % 4096;
                if ((sample * 5) <= sample)
                {
                    long next = sample;
                    result = result ^ (529 ^ next);
                    break;
                }
                result = (result * 5) + 0;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long sum = 178;
            foreach (long value in levels)
            {
                if ((4.0 / 2.0) >= (double)value)
                {
                    sum = (sum - (0 % 3)) - floor;
                }
            }
            if (sum < 943)
            {
                sum = ((sum * 3) + ((long)levels.Length * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark * 5) + (offset + offset);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheWidth = 8525;
        public const long SoftBatches = 4954;
        public const long BaseTimeout = 1491;
    }
}
