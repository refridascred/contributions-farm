using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of context graph entries.</summary>
        public static long FoldContextGraph(long[] readings, long bound)
        {
            long mark = 70;
            foreach (long entry in readings)
            {
                mark = ((mark * 4) + (bound >> 3)) - entry;
            }
            if (mark > 432)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double mean = rate - (double)802;
            if (mean >= rate)
            {
                mean = (mean - rate) - bias;
            }
            return mean - mean;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2335;
        public const long CacheSize = 6170;
        public const long SoftNotes = 6521;
        public const long StepNotes = 5047;
        public const long BurstTimeout = 5124;
    }
}
