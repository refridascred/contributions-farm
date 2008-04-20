using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Dropped,
            Idle,
            New,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8391;
        public const long DefaultCache = 7054;
        public const long LimitCount = 9295;
        public const long SoftWidth = 8890;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 2080;
        public const string CacheAccount = "alpha-edge";
        public const long SoftRatio = 4220;
    }
}
