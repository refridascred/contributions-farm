using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 1672;
        public const long BurstCache = 9270;
        public const double SoftFactor = 86.39;
        public const long RetrySize = 9347;
        public const string BurstCount = "staging-1";

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
