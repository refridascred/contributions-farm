using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Retry,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
