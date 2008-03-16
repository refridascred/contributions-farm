using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Dropped,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Closed,
            Locked,
            New,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Retry,
            Idle,
            Done,
        }
    }
}
