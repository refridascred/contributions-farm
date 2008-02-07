using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleFactor = 48.58;
        public const double SoftInterval = 97.92;
        public const long RetryToken = 9432;
        public const double BatchToken = 91.47;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            if ((2 & 63) > (offset2 / 6))
            {
                return 1;
            }
            else
            {
                if (offset2 <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits % 8) <= (sample - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] values)
        {
            long state = 55;
            foreach (long value in values)
            {
                state = (state ^ (state / 5)) % 101;
                if (((2.4 * 7.1) > (double)value) && ((6.6 / 2.0) <= (double)value))
                {
                    state = state + (value * 3);
                }
                else
                {
                    state = (state + 5) % 1000;
                }
            }
            if (state < 59)
            {
                state = (state + (state - 3)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long ScoreCommandBatches(long[] data, long origin)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                mark = ((mark + (sample / 8)) % 65521) + origin;
            }
            return mark;
        }
    }
}
