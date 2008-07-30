using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
