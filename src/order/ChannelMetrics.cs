using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Queued,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Synced,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Idle,
            Stale,
        }
    }
}
