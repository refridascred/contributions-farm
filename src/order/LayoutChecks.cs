using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Active,
        }
    }
}
