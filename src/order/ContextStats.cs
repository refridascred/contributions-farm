using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultCount = 4.92;
        public const double RetryAccount = 2.15;
        public const long HardAccount = 9033;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-1";
        public const long DefaultRatio = 9539;
        public const long CacheScore = 892;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}
