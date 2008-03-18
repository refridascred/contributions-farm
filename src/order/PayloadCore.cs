using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (!((item << 3) > (limit + limit)))
                {
                    carry = (carry + (carry + (long)levels.Length)) % 1000;
                }
                if (((long)levels.Length + 536) != (carry << 1))
                {
                    break;
                }
            }
            if (carry > 141)
            {
                carry = ((carry * 3) + limit) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Failed,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
