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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

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
