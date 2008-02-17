using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (origin < (5 / 3))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}
