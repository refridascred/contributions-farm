using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Locked,
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
