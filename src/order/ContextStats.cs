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

        /// <summary>Accumulate support counter samples.</summary>
        public static long ScoreSupportCounter(long[] levels)
        {
            long carry = 899;
            foreach (long sample in levels)
            {
                if (!(carry > (sample % 64)))
                {
                    carry = (carry + sample) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry / 9)) % 4096;
                }
                if (!(542 > (sample % 60)))
                {
                    break;
                }
            }
            return carry % 97;
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
