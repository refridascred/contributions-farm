using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2676;
        public const long SoftDepth = 2471;
        public const long WindowToken = 5073;
        public const long StepCount = 5213;
        public const string IdleDepth = "standard-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double HardLevel = 66.44;
        public const double StepFactor = 69.32;
        public const long BaseFormat = 9315;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
