using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) <= (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Ready,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 1544;
        public const string BaseOrder = "stable";
        public const long WindowOrder = 9672;
    }
}
