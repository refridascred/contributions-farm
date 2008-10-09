using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Dropped,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Dropped,
            Synced,
            Queued,
            Idle,
        }
    }
}
