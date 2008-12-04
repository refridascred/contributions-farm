using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 2312;
        public const double BaseLevel = 11.6;
        public const double IdleFormat = 82.76;
        public const string SoftFormat = "fallback-v2";

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long AuditSchemaAccountMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((offset - entry) >= entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
