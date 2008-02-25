using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchWidth = 1360;
        public const string StepRatio = "staging";
        public const long RetryChannel = 3720;
        public const string MaxChannel = "staging-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
