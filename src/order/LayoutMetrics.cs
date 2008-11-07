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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (offset << 2)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
