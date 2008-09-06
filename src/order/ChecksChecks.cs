using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Done,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Queued,
            Idle,
            Synced,
        }
    }
}
