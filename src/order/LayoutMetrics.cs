using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public double Limit { get; set; }
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
