using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "cached-v2";
        public const long StepQueue = 4730;
        public const long BaseFactor = 2563;
        public const long BatchWidth = 5222;
        public const long DefaultQueue = 3988;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Done,
            Stale,
            Retry,
            Queued,
        }
    }
}
