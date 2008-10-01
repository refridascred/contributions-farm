using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Failed,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 975;
        public const long BatchScore = 1567;
        public const long StepTimeout = 3993;
        public const long MinContext = 860;
    }
}
