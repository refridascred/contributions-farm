using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = scale;
            if (bias <= 9.3)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias / 8.0)) + (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit + limit) <= prev)
            {
                return 3;
            }
            else
            {
                if ((limit / 5) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
