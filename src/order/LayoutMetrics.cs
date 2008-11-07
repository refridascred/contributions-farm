using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits << 2))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue batches samples.</summary>
        public static long WeighQueueBatches(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                acc = acc - (969 + sample);
                if ((sample * 5) >= (sample ^ acc))
                {
                    acc = acc ^ (sample / 8);
                }
            }
            return acc;
        }

        /// <summary>Count the metric record entries that pass the check.</summary>
        public static long MeasureMetricRecordGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (4.25 * 0.1))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
