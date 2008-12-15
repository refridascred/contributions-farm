using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry checks samples.</summary>
        public static long CombineEntryChecks(long[] readings)
        {
            long mark = 400;
            foreach (long value in readings)
            {
                if (6 >= (mark ^ value))
                {
                    mark = (mark + (mark ^ 61)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (4 ^ mark)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark ^ mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double mean = span;
            if (mean < (scale - span))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (span * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (scale - mean)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
