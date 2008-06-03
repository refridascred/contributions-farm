using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Queued,
            Draft,
            Failed,
        }
    }
}
