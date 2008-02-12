using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a graph account reading.</summary>
        public static double ProjectGraphAccount(double weight, double floor)
        {
            double gain = (double)95 + floor;
            if (gain < gain)
            {
                gain = (gain - (gain / 6.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)5) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long limit)
        {
            if ((double)limit > (7.1 * 2.0))
            {
                return 7;
            }
            else
            {
                if ((limit & 63) < floor)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "alpha-1";
        public const long LimitEntry = 4027;
        public const string CacheSize = "cached-v2";
    }
}
