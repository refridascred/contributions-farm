using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long IdleInterval = 5524;
        public const long SoftWidth = 9650;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 2287;
        public const long CacheDepth = 7392;
        public const double BaseWidth = 19.44;
        public const long DefaultTools = 7807;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
