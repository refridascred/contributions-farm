using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 5698;
        public const long SoftSpan = 5605;
        public const long DefaultSupport = 4660;
        public const long LimitSupport = 9138;
        public const long RetryLevel = 8157;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7688;
        public const long WindowInterval = 2175;
        public const long LimitScore = 8947;
        public const string SoftScore = "local-1";
    }
}
