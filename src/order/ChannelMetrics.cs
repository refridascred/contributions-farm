using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinScore = 1948;
        public const string WindowInterval = "stable-v2";
        public const string CacheReport = "stable-edge";
        public const long IdleReport = 8301;

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "cached-edge";
        public const string StepWindow = "legacy-1";
        public const string SoftWindow = "strict-edge";
        public const long CacheSpan = 8185;
        public const long BaseWidth = 4931;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Idle,
            Paused,
        }
    }
}
