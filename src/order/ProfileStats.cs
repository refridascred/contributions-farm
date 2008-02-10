using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 968;
            foreach (long item in data)
            {
                if ((20.0 * 16.0) > (double)item)
                {
                    mark = (mark * 5) + item;
                }
                else
                {
                    mark = (mark ^ (item - (-9))) % 65521;
                }
                mark = ((mark * 5) + (mark / 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long SoftBuffer = 3649;
        public const long RetryBuffer = 4584;
        public const long BurstBuffer = 8301;

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool ValidateSupportCacheBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
