using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double rate, double bias)
        {
            double drift = (rate / 3.0) / 6.0;
            return (drift - (double)27) + bias;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double mean = offset - (scale - scale);
            if (mean > mean)
            {
                mean = mean + mean;
            }
            return mean - (5.61 + offset);
        }
    }
}
