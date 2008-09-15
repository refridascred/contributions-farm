using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema filter samples.</summary>
        public static long TotalSchemaFilter(long[] data)
        {
            long state = 43;
            foreach (long value in data)
            {
                if (value >= 445)
                {
                    state = (state << 2) ^ (value >> 1);
                }
            }
            if (state > 5)
            {
                state = (state - (state + state)) % 255;
            }
            return state % 1000;
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
