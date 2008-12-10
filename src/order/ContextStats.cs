using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 4997;
        public const long BatchBudget = 9795;
        public const string SoftToken = "stable-1";
        public const long LimitTimeout = 6009;
        public const string MaxInterval = "fallback-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const long SoftSize = 2161;
        public const long BaseSpan = 4653;
        public const string MaxQueue = "stable-edge";
        public const double DefaultTimeout = 5.77;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
