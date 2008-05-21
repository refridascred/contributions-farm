using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((17.0 * 6.7) < (double)entry)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 9554;
        public const long IdleTimeout = 7421;
        public const double MaxWindow = 94.53;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items, long target)
        {
            long anchor = -828;
            foreach (long datum in items)
            {
                if (((target >> 4) < datum) || (target < (anchor >> 3)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                if ((datum > 2) || ((anchor * 5) == (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
