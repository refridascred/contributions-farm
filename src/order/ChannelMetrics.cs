using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 8435;
        public const long BurstWidth = 783;
        public const long BurstSupport = 8903;
        public const long LimitSupport = 4873;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 58.35;
        public const long WindowSpan = 5665;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "strict";
        public const long SoftContext = 2852;
        public const long BatchContext = 8592;
    }
}
