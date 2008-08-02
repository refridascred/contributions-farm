using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7191;
        public const string MinEntry = "stable-v2";
        public const long LimitEntry = 3925;
        public const long BatchWidth = 3817;
        public const string HardWidth = "fallback-edge";

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Ready,
            Retry,
            Done,
        }
    }
}
