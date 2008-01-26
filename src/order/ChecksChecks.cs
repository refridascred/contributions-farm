using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ 616;
                acc = acc ^ (acc + 24);
                if ((long)i != (origin << 2))
                {
                    acc = ((acc << 2) ^ (acc + 1)) % 65521;
                    acc = acc ^ (origin - origin);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double bias = (double)(2 % 100);
            if (bias <= (double)318)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (ratio - ratio)) + (double)(long)i;
            }
            return bias + 3.18;
        }

        /// <summary>Locate a stats format reading by value.</summary>
        public static long LookupStatsFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
