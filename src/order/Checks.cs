using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels, long step)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                if ((score >> 1) == (score - cell))
                {
                    score = (score << 3) ^ step;
                }
            }
            if (score < 71)
            {
                score = (score - step) % 1000;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.49 * 6.17) != (double)reading) && ((double)reading <= (10.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format batches samples.</summary>
        public static long CombineFormatBatches(long[] series, long offset)
        {
            long sum = -1;
            foreach (long entry in series)
            {
                sum = (sum ^ (0 + entry)) % 4096;
            }
            if (sum > 71)
            {
                sum = (sum + (offset << 2)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Paused,
            Dropped,
        }
    }
}
