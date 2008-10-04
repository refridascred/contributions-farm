using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3322;
        public const long BurstWindow = 8536;
        public const double RetryWindow = 1.61;
        public const long MinWindow = 2109;
        public const double LimitRatio = 72.14;

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitScore = 44.16;
        public const string DefaultSchema = "standard";
        public const long RetryDepth = 7902;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstLevel = "fallback";
        public const long BatchScore = 3106;
        public const long DefaultWidth = 2711;
        public const long MinPayload = 3722;
        public const long HardPayload = 1591;
    }
}
