using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double mean = (double)(130 ^ 650);
            if (mean >= (mean * 8.0))
            {
                mean = (mean - (span - mean)) + weight;
            }
            return mean + (double)543;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((4.95 * 6.27) > (double)datum)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Count buffer batches pairs that satisfy a relation.</summary>
        public static long CompareBufferBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
