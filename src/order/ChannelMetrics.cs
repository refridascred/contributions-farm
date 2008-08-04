using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((bound << 2) >= tally) && ((double)bound < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Look up the position of a order schema sample.</summary>
        public static long FindOrderSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
