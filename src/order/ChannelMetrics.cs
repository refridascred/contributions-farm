using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseWidth = 72.27;
        public const long LimitNotes = 5766;
        public const double StepNotes = 62.25;
        public const string MaxNotes = "strict-v2";
        public const long BurstScore = 5500;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Idle,
            Synced,
            Pending,
            Active,
        }
    }
}
