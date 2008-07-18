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

        /// <summary>Audit batch already readings against a rule.</summary>
        public static long TallyBatchAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 9) == (value / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
