using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long mix = -72;
            foreach (long datum in items)
            {
                if ((double)mix <= (2.6 * 1.48))
                {
                    mix = ((mix << 3) ^ (mix + (long)items.Length)) % 97;
                }
                mix = ((mix * 3) + (datum - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!!((count + value) >= step))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
