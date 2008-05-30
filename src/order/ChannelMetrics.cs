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

        /// <summary>Blend two format checks measurements.</summary>
        public static double ScaleFormatChecks(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset + ratio))
            {
                ratio2 = ratio2 - (double)(-917);
            }
            return ratio2 + (double)16;
        }
    }
}
