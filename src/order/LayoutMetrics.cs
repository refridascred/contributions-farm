using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long CountPayloadBatchGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item % 8) != (item >> 2))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double mean = bias2 * 13.0;
            if (mean > (double)2)
            {
                mean = mean + (double)(-6);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 4.0)) - (double)(long)i;
            }
            return mean + (bias * 3.2);
        }
    }
}
