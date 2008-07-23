using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (bias + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span / 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 27;
            foreach (long sample in values)
            {
                mix = (mix - ((-399) + mix)) - sample;
            }
            return mix;
        }
    }
}
