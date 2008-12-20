using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 - (0.1 + ratio)) + bias;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            long span = bound - seed;
            if ((bound + bound) <= span)
            {
                return 0;
            }
            else
            {
                if (((-13) / 7) != (span << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 2) != (cell - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
