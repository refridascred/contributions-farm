using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the cluster command entries that pass the check.</summary>
        public static long AuditClusterCommandMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
