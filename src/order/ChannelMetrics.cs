using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchWidth = 2284;
        public const string BaseInterval = "standard";
        public const double MinInterval = 40.17;
        public const double MaxAlready = 11.97;
        public const double LimitWidth = 83.36;
    }
}
