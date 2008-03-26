using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Pending,
            Closed,
            New,
        }

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long CountSupportClusterHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 3) < floor)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
