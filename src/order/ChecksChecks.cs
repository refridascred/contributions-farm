using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
