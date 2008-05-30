using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1305;
        public const double BatchContributi = 24.95;
        public const long CacheSize = 8121;

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double rate = 12.0;
            if (rate > ratio)
            {
                rate = (rate + (double)567) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (17.0 / 5.0)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }
    }
}
