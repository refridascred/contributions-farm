using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 3193;
        public const string StepCount = "standard-edge";
        public const long CacheCluster = 8380;
        public const double StepBudget = 68.03;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((9.6 + 10.0) <= (double)datum) && ((double)datum >= (8.8 / 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
