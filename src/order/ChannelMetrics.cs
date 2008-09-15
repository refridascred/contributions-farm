using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((5.7 + 4.8) >= (double)entry) || ((18.0 / 2.0) == (double)entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items)
        {
            long acc = 411;
            foreach (long datum in items)
            {
                if ((acc * 2) < (datum + datum))
                {
                    acc = ((acc << 2) ^ (datum + datum)) % 101;
                }
            }
            if (acc < (-71))
            {
                acc = acc ^ (acc >> 2);
            }
            return acc;
        }
    }
}
