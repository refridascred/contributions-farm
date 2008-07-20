using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 6.53;
        public const long LimitSession = 6495;
        public const long StepSession = 9396;
        public const long BurstScore = 3083;
        public const double CacheDepth = 24.97;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7484;
        public const long BaseEditor = 9864;
        public const double SoftTimeout = 10.16;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
