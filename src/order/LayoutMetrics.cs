using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((item >> 4) != (seed - 0)) && ((83 + seed) >= item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Synced,
            New,
            Idle,
            Done,
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long TallyCounterOrder(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if (!(acc < (79 & 63)))
                {
                    acc = ((acc ^ (981 - acc)) % 255) ^ reading;
                }
            }
            return acc;
        }
    }
}
