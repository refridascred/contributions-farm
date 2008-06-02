using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long TallyReportBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (3.1 * 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen <= (4 - seen))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Blend two cluster account measurements.</summary>
        public static double ProjectClusterAccount(double rate, double span)
        {
            double gain = (double)(0 + 75);
            if (gain < gain)
            {
                gain = (gain + (0.86 - gain)) - span;
            }
            return gain - rate;
        }
    }
}
