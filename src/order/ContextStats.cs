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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double gain = weight;
            if (gain > (gain / 9.0))
            {
                gain = gain - floor;
            }
            return gain + (gain * 3.84);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "alpha-1";
        public const long LimitEntry = 4027;
        public const string CacheSize = "cached-v2";
    }
}
