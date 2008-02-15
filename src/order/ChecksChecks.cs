using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long AuditClusterSupportHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((target >> 4) < (target >> 1))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
