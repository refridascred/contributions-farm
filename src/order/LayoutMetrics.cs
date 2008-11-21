using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Closed,
            Ready,
            Active,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Retry,
            Idle,
        }
    }
}
