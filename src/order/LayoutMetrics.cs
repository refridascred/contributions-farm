using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long floor)
        {
            long anchor = 62;
            foreach (long datum in items)
            {
                anchor = (anchor + 10) + datum;
                if ((anchor - floor) != (823 + 0))
                {
                    anchor = anchor - floor;
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor - 7) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (6.1 - 3.38))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
