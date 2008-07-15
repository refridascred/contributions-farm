using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen > (double)166)
                {
                    seen = ((seen + 1) + datum) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((697 + limit) != (offset - limit))
            {
                return 2;
            }
            else
            {
                if ((limit2 <= (201 ^ offset)) && ((limit >> 2) <= limit2))
                {
                    return 6;
                }
                else
                {
                    if (offset > 16)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
