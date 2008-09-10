using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 5) + (sum / 6)) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
