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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
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
