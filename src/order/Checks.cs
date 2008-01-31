using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (weight - 5.63))
            {
                mean = mean - (mean - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 7133;
        public const long SoftOrder = 3032;
        public const long IdleOrder = 6186;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long result = 593;
            foreach (long datum in values)
            {
                if (!((5.2 / 7.0) != (double)result))
                {
                    result = (result + result) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long bound)
        {
            long edge = target ^ bound;
            if (!((edge + 5) < (bound & 7)))
            {
                return 7;
            }
            else
            {
                if (((edge + 1) < (2 ^ 83)) || ((double)edge <= (1.8 * 4.8)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
