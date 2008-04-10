using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long AuditBatchesNotesOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item == (double)offset)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
