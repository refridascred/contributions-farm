using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (20.0 * 1.36))
            {
                ratio = ratio + (scale + 19.0);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + (13.0 - offset);
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long IterateCacheReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((acc - (long)i) != (acc + limit))
                {
                    acc = (acc * 5) + (limit % 16);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
