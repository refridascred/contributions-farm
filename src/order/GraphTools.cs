using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((step & 3) != (1 - step))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Queued,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Failed,
            Retry,
            Active,
            Done,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Ready,
            Synced,
            Draft,
        }
    }
}
