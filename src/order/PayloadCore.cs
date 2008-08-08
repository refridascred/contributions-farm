using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseTimeout = "primary-edge";
        public const long BurstSize = 1065;
        public const double LimitDepth = 7.96;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 141;
        public const string BaseChannel = "latest";
        public const long WindowChannel = 1038;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySpan = "strict-edge";
        public const long DefaultWidth = 3602;
        public const long MaxInterval = 1198;

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-1";
        public const long RetryTimeout = 6862;
        public const double CacheSpan = 70.12;
        public const double MinSpan = 15.96;
    }
}
