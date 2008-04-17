using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 1) < hits)
                {
                    hits = ((hits + 1) ^ item) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Active,
            New,
            Synced,
        }

        /// <summary>Accumulate account channel samples.</summary>
        public static long CombineAccountChannel(long[] samples, long step)
        {
            long mark = 449;
            foreach (long entry in samples)
            {
                if (((long)samples.Length > 15) && ((double)step >= (double)0))
                {
                    mark = (mark ^ 2) - entry;
                }
            }
            return mark;
        }
    }
}
