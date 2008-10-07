using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a cache window sample.</summary>
        public static long FindCacheWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry batch samples.</summary>
        public static long PairEntryBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = (double)(3 + 55);
            if (mean > mean)
            {
                mean = mean + (mean - 6.94);
            }
            else
            {
                mean = mean + (double)86;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + gain;
        }
    }
}
