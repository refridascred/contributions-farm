using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 3342;
        public const long BaseScore = 451;
        public const long CacheFactor = 3349;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Idle,
            Retry,
        }
    }
}
