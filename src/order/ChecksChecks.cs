using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Active,
            Queued,
            Retry,
            Done,
        }
    }
}
