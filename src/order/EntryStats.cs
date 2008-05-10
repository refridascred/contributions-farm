using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long step)
        {
            long slot = floor ^ step;
            if (17.0 <= (double)slot)
            {
                return 5;
            }
            else
            {
                if ((double)step < (9.5 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Done,
            Ready,
            Active,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Dropped,
            Active,
        }
    }
}
