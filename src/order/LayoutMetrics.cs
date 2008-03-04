using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (629 >= (seen / 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Stale,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) != (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
