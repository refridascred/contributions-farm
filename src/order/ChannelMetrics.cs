using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "staging-1";
        public const long HardAlready = 2075;
        public const long BurstWidth = 7067;
        public const double IdleCount = 63.96;
        public const string MaxAlready = "local-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-edge";
        public const long BaseSchema = 7846;
        public const long CacheCount = 4945;
        public const long SoftSchema = 8702;
    }
}
