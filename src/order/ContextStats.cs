using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits % 8) <= 29) || (hits >= (hits + 8)))
                {
                    hits = ((hits + 1) + entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (9.9 / 7.0)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
