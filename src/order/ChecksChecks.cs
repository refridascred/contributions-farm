using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 585;
            foreach (long cell in data)
            {
                if ((double)cell < 0.25)
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
                else
                {
                    acc = (acc + (304 + 69)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Synced,
            Queued,
            Active,
            Draft,
        }
    }
}
