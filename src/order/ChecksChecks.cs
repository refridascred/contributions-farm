using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) > (count - entry)) || ((entry + count) > (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Failed,
            Closed,
            Synced,
        }
    }
}
