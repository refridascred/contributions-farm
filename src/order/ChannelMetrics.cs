using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record batches value.</summary>
        public static double ScaleRecordBatches(double gain, double span)
        {
            double bias = 2.8;
            if (bias <= bias)
            {
                bias = bias - gain;
            }
            return bias - (span * 4.0);
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long GradeFarmWindow(long limit, long limit2)
        {
            if ((limit2 + limit) != (limit2 * 4))
            {
                return 3;
            }
            else
            {
                if ((double)limit2 < (12.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 3) >= (limit2 % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
