using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "local-v2";
        public const string SoftDepth = "strict-v2";
        public const long WindowOrder = 3439;

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitFactor = 29.72;
        public const long MinLevel = 2698;
        public const long BaseTimeout = 8314;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 2978;
        public const string RetryFactor = "latest";
        public const string BatchSpan = "local-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchTimeout = "legacy";
        public const string SoftInterval = "standard";
        public const double StepCount = 24.41;
    }
}
