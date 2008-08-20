using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Closed,
            Queued,
            Dropped,
            Stale,
        }
    }
}
