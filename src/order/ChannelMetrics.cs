using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheWidth = 5625;
        public const long SoftSize = 8427;
        public const string CacheLevel = "stable-v2";
        public const string IdleRatio = "open-1";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((829 << 3) >= (seen + 56))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
