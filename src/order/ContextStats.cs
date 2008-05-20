using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (322 >= (count << 3))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            New,
        }
    }
}
