using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long AuditPayloadFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry == (4.49 + 7.8)) || (((hits + entry) < (entry % 10)) && (hits >= (entry >> 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
