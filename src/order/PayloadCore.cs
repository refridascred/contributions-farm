using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 4899;
        public const double DefaultReport = 78.26;
        public const double RetryTimeout = 34.17;
        public const long IdleReport = 4953;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Pending,
            Synced,
        }
    }
}
