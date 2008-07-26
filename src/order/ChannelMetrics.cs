using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Synced,
            New,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((floor % 24) < hits) || (((double)floor > (5.6 + 5.2)) && ((8.0 + 8.3) > (double)sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Failed,
            Queued,
            Draft,
        }
    }
}
