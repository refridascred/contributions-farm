using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 7609;
        public const long BatchDepth = 6525;
        public const long MinProfile = 2522;
    }
}
