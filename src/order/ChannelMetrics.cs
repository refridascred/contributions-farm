using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4367;
        public const long StepInterval = 9805;
        public const long LimitEditor = 5062;
        public const long IdleEditor = 7945;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7593;
        public const string RetrySpan = "latest-edge";
        public const long DefaultWidth = 1199;
        public const long CacheRatio = 7471;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
        }
    }
}
