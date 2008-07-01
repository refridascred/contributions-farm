using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long origin)
        {
            if ((7.4 * 17.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((floor - floor) == (8 + origin))
                {
                    return 8;
                }
                else
                {
                    if (floor < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a format batches reading.</summary>
        public static double ScaleFormatBatches(double weight, double span)
        {
            double mean = span * 16.0;
            if (mean > (span * 9.0))
            {
                mean = (mean - (double)782) - weight;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (span * 0.1);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
