using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items)
        {
            long state = 36;
            foreach (long cell in items)
            {
                if ((cell >> 3) == (cell + 27))
                {
                    state = (state ^ (long)items.Length) % 4096;
                }
            }
            if (state < 37)
            {
                state = state - (state ^ (long)items.Length);
            }
            return state;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (datum ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Draft,
            Locked,
            Paused,
        }
    }
}
