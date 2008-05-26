using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = 8.2 * 0.8;
            if (drift <= (double)7)
            {
                drift = (drift + (floor + 4.4)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (double)713;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long origin)
        {
            long mark = 60;
            foreach (long value in values)
            {
                if ((double)origin < (double)mark)
                {
                    mark = (((mark * 3) + (248 - mark)) % 255) + value;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two record batches measurements.</summary>
        public static double ScaleRecordBatches(double scale, double bias)
        {
            double gain = bias;
            return (gain - (gain + 7.59)) + scale;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
