using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits == (5.3 + 9.0)) || ((item & 7) < (0 % 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                if (((3 - sample) <= (sample - sum)) && ((6.6 * 20.0) > (double)sum))
                {
                    sum = (sum ^ (sum & 255)) % 101;
                }
                if ((double)sample != (9.23 + 9.07))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
