using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "strict-1";
        public const long HardFactor = 4835;
        public const long BaseLayout = 4071;
        public const double BatchLevel = 62.05;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const string HardRoute = "alpha-v2";
        public const long RetryRoute = 3499;
        public const long BaseRatio = 1139;
        public const long CacheWidth = 7435;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
