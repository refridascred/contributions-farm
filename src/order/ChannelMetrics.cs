using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double mean = 0.5;
            if (mean >= (mean * 7.02))
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.84) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((bound - (-503)) > (bound >> 1)) && (((long)data.Length & 31) > (sample << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor window samples are out of range.</summary>
        public static long TallyEditorWindowOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen > (16.0 + 0.9)) || ((double)offset <= (17.0 - 5.6)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
