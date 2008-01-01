using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Retry,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                if (((double)83 > (double)(long)items.Length) || ((limit + anchor) >= anchor))
                {
                    anchor = ((anchor * 2) + (513 + datum)) % 1000;
                }
                else
                {
                    anchor = (anchor + (limit - 4)) % 1000;
                }
            }
            if (anchor > (-5))
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 4096;
        }
    }
}
