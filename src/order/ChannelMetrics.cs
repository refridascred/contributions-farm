using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two metrics record measurements.</summary>
        public static double ScaleMetricsRecord(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (2.3 + ratio))
            {
                ratio2 = (ratio2 - (ratio2 - ratio)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (18.0 / 7.0)) + (double)(long)i;
            }
            return ratio2 - (double)66;
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
