using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((82 + entry) != (seed - seed)) && ((double)entry != (9.0 - 16.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
