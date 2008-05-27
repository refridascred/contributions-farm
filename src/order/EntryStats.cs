using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LookupChannelBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4034;
        public const long DefaultFilter = 6819;
        public const double RetryFilter = 21.34;
        public const double SoftDepth = 13.5;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seen <= (double)floor) && ((reading >> 2) >= (79 << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format schema value from a seed.</summary>
        public static long SeriesFormatSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 2) ^ (741 & 63)) % 4096;
                sum = sum ^ bound;
                if (!((bound / 4) != (sum << 3)))
                {
                    sum = ((sum * 4) + sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Closed,
            Pending,
            Draft,
        }
    }
}
