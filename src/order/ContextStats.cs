using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a filter session sample.</summary>
        public static long LocateFilterSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the commits contributi entries that pass the check.</summary>
        public static long AuditCommitsContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) <= (tally >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
