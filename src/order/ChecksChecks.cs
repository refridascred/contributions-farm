using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFactor = 1846;
        public const string LimitWidth = "fallback-v2";
        public const long SoftFilter = 7073;
        public const long StepBudget = 7192;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const string StepSize = "staging-v2";
        public const long LimitBudget = 1419;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
