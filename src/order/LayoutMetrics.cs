using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Idle,
            Dropped,
            Draft,
        }
    }
}
