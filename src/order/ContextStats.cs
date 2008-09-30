using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long mark = 97;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry % 7)) - origin;
            }
            return mark % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + reading) != (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
